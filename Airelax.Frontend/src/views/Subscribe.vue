<template>
  <div class="container-xl">
    <FrontPage></FrontPage>
    <div class="row rwd flex-md-row-reverse">
      <div class="col-12 col-md-6">
        <div class="sticky">
          <SubRoom v-if="get" :room="room" :nightCount="nightCount"></SubRoom>
          <SubPriceDetail
              v-if="get && fullWidth >= 768"
              :room="room"
              :nightCount="nightCount"
          ></SubPriceDetail>
        </div>
      </div>
      <div class="col-12 col-md-6">
        <YourTrip :fullWidth="fullWidth"></YourTrip>
        <PayWay :fullWidth="fullWidth"></PayWay>
        <SubPriceDetail
            v-if="get && fullWidth < 768"
            :room="room"
            :nightCount="nightCount"
        ></SubPriceDetail>
        <RequiredInfo :fullWidth="fullWidth"></RequiredInfo>
        <Unsubscribe></Unsubscribe>
        <CheckAndSub v-if="token&&orderId" :token="token" :orderId="orderId"></CheckAndSub>
      </div>
    </div>
  </div>
</template>
<style lang="scss">
@import "../assets/css/reset.css";
@import url(https://fonts.googleapis.com/css2?family=Noto+Sans+TC:wght@100;300;400;500;700;900&display=swap);
@import "../assets/sass/Subscribe/Subscribe.scss";
</style>
<script>
import axios from "axios";
import SubRoom from "../components/Subscribe/SubRoom.vue";
import FrontPage from "../components/Subscribe/FrontPage.vue";
import YourTrip from "../components/Subscribe/YourTrip.vue";
import PayWay from "../components/Subscribe/PayWay.vue";
import SubPriceDetail from "../components/Subscribe/SubPriceDetail.vue";
import RequiredInfo from "../components/Subscribe/RequiredInfo.vue";
import Unsubscribe from "../components/Subscribe/Unsubscribe.vue";
import CheckAndSub from "../components/Subscribe/CheckAndSub.vue";

export default {
  components: {
    SubRoom,
    FrontPage,
    YourTrip,
    PayWay,
    SubPriceDetail,
    RequiredInfo,
    Unsubscribe,
    CheckAndSub,
  },
  created() {
    axios
        .get(`/api/houses/${this.$route.params.houseId}`, {
          headers: {
            "Access-Control-Allow-Origin": "*",
          },
        })
        .then(() => {
          this.room = this.$store.state.room;
          this.get = true;
        });

    axios("/api/orders", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      data: this.OrdersInput,
    }).then(res => {
      const data = res.data;
      console.log(data)
      this.orderId = data.orderId;
      this.token = data.token;
    }).catch(err => console.log(err));
  },
  data() {
    const isDateEmpty = Object.keys(this.$store.state.date).length === 0;
    return {
      room: Object,
      nightCount: this.$store.state.nightCount,
      get: false,
      fullWidth: 0,
      OrdersInput: {
        houseId: this.$route.params.houseId,
        startDate: isDateEmpty
            ? null
            : this.$store.state.date.start
                .replace(/[年]/, "-")
                .replace(/[月]/, "-")
                .replace("日", ""),
        endDate: isDateEmpty
            ? null
            : this.$store.state.date.end
                .replace(/[年]/, "-")
                .replace(/[月]/, "-")
                .replace("日", ""),
        adult: this.$store.state.adult,
        child: this.$store.state.child,
        baby: this.$store.state.toddler,
      },
      orderId: "",
      token: "",
    };
  },
  provide() {
    return {
      data: this.$store.state.room,
      token: this.token
    }
  },
  computed: {
    night() {
      return this.$store.state.nightCount
    }
  },
  watch: {
    fullWidth(val) {
      this.fullWidth = val;
    },
    night(val) {
      this.nightCount = val
    }
  },
  mounted() {
    window.scrollTo(0, 0);
    const vm = this;
    this.fullWidth = document.body.clientWidth;
    window.addEventListener("resize", function () {
      vm.fullWidth = document.body.clientWidth;
    });
  },
};
</script>
