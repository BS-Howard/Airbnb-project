<template>
  <div id="nav">
    <div class="LinkGroup col-10" v-if="$store.state.login.token != ''" @click="changeLink">
      <div class="search default">
        <router-link to="/" class="text-decoration-none router-link-exact-active">
          <div class="col-12 linkItem">
            <a class="col-12">
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; fill: none; height: 24px; width: 24px; stroke: currentcolor; stroke-width: 4; overflow: visible;">
                <g fill="none">
                  <path
                      d="m13 24c6.0751322 0 11-4.9248678 11-11 0-6.07513225-4.9248678-11-11-11-6.07513225 0-11 4.92486775-11 11 0 6.0751322 4.92486775 11 11 11zm8-3 9 9"/>
                </g>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a class="col-12">首頁</a>
          </div>
        </router-link>
      </div>
      <div class="wish">
        <router-link to="/wishList" class="text-decoration-none router-link-exact-active">
          <div class="col-12 linkItem">
            <a>
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; fill: none; height: 24px; width: 24px; stroke: currentcolor; stroke-width: 2.66667; overflow: visible;">
                <path
                    d="m16 28c7-4.733 14-10 14-17 0-1.792-.683-3.583-2.05-4.95-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05l-2.051 2.051-2.05-2.051c-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05-1.367 1.367-2.051 3.158-2.051 4.95 0 7 7 12.267 14 17z"/>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a>心願單</a>
          </div>
        </router-link>
      </div>
      <div @click="trip" class="wish">
        <div class="trip text-decoration-none">
          <div class="col-12 linkItem">
            <a>
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentcolor"
                   style="display:block">
                <path
                    d="M29.24 22.68c-.16-.39-.31-.8-.47-1.15l-.74-1.67-.03-.03c-2.2-4.8-4.55-9.68-7.04-14.48l-.1-.2c-.25-.47-.5-.99-.76-1.47-.32-.57-.63-1.18-1.14-1.76a5.3 5.3 0 00-8.2 0c-.47.58-.82 1.19-1.14 1.76-.25.52-.5 1.03-.76 1.5l-.1.2c-2.45 4.8-4.84 9.68-7.04 14.48l-.06.06c-.22.52-.48 1.06-.73 1.64-.16.35-.32.73-.48 1.15a6.8 6.8 0 007.2 9.23 8.38 8.38 0 003.18-1.1c1.3-.73 2.55-1.79 3.95-3.32 1.4 1.53 2.68 2.59 3.95 3.33A8.38 8.38 0 0022.75 32a6.79 6.79 0 006.75-5.83 5.94 5.94 0 00-.26-3.5zm-14.36 1.66c-1.72-2.2-2.84-4.22-3.22-5.95a5.2 5.2 0 01-.1-1.96c.07-.51.26-.96.52-1.34.6-.87 1.65-1.41 2.8-1.41a3.3 3.3 0 012.8 1.4c.26.4.45.84.51 1.35.1.58.06 1.25-.1 1.96-.38 1.7-1.5 3.74-3.21 5.95zm12.74 1.48a4.76 4.76 0 01-2.9 3.75c-.76.32-1.6.41-2.42.32-.8-.1-1.6-.36-2.42-.84a15.64 15.64 0 01-3.63-3.1c2.1-2.6 3.37-4.97 3.85-7.08.23-1 .26-1.9.16-2.73a5.53 5.53 0 00-.86-2.2 5.36 5.36 0 00-4.49-2.28c-1.85 0-3.5.86-4.5 2.27a5.18 5.18 0 00-.85 2.21c-.13.84-.1 1.77.16 2.73.48 2.11 1.78 4.51 3.85 7.1a14.33 14.33 0 01-3.63 3.12c-.83.48-1.62.73-2.42.83a4.76 4.76 0 01-5.32-4.07c-.1-.8-.03-1.6.29-2.5.1-.32.25-.64.41-1.02.22-.52.48-1.06.73-1.6l.04-.07c2.16-4.77 4.52-9.64 6.97-14.41l.1-.2c.25-.48.5-.99.76-1.47.26-.51.54-1 .9-1.4a3.32 3.32 0 015.09 0c.35.4.64.89.9 1.4.25.48.5 1 .76 1.47l.1.2c2.44 4.77 4.8 9.64 7 14.41l.03.03c.26.52.48 1.1.73 1.6.16.39.32.7.42 1.03.19.9.29 1.7.19 2.5z"/>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a>旅程</a>
          </div>
        </div>
      </div>
      <div class="email">
        <router-link :to="{ path: `/message/${$store.state.login.memberId}`}"
                     class="text-decoration-none router-link-exact-active">
          <div class="col-12 linkItem">
            <a>
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; height: 24px; width: 24px; fill: currentcolor;">
                <path
                    d="m26 2c2.6887547 0 4.8818181 2.12230671 4.9953805 4.78311038l.0046195.21688962v14c0 2.6887547-2.1223067 4.8818181-4.7831104 4.9953805l-.2168896.0046195h-5.845l-4.1548949 5.0792674-4.1561051-5.0792674h-5.844c-2.61406707 0-4.75959878-2.0060384-4.98113724-4.5626572l-.01424325-.2204532-.00461951-.2168896v-14c0-2.6887547 2.12230671-4.88181811 4.78311038-4.99538049l.21688962-.00461951zm0 2h-20c-1.59768088 0-2.90366088 1.24891996-2.99490731 2.82372721l-.00509269.17627279v14c0 1.5976809 1.24891996 2.9036609 2.82372721 2.9949073l.17627279.0050927h6.7918643l3.2071357 3.92 3.2080542-3.92h6.7929458c1.5976809 0 2.9036609-1.24892 2.9949073-2.8237272l.0050927-.1762728v-14c0-1.59768088-1.24892-2.90366088-2.8237272-2.99490731z"/>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a>收件匣</a>
          </div>
        </router-link>
      </div>
      <div class="wish">
        <a href="/member" class="person text-decoration-none">
          <div class="col-12 linkItem">
            <a>
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; height: 24px; width: 24px; fill: currentcolor;">
                <path
                    d="m16 1c8.2842712 0 15 6.71572875 15 15 0 8.2842712-6.7157288 15-15 15-8.28427125 0-15-6.7157288-15-15 0-8.28427125 6.71572875-15 15-15zm0 8c-2.7614237 0-5 2.2385763-5 5 0 2.0143973 1.2022141 3.7998876 2.9996346 4.5835001l.0003231 2.0984999-.1499943.0278452c-2.8326474.5613112-5.31897338 2.2230336-6.93575953 4.5872979 2.34343054 2.291067 5.54974273 3.7028569 9.08579613 3.7028569 3.5355506 0 6.7414538-1.4113884 9.0850203-3.701476-1.6141801-2.3628535-4.0978119-4.0247647-6.929184-4.5867938l-.1558786-.0287302.001228-2.0991413c1.7288399-.7547474 2.9066959-2.4357565 2.9936498-4.355479l.0051645-.2283797c0-2.7614237-2.2385763-5-5-5zm0-6c-7.17970175 0-13 5.82029825-13 13 0 2.9045768.95257276 5.5866683 2.56235849 7.7509147 1.42074739-1.9134907 3.33951478-3.4002416 5.53860831-4.2955956l.3480332-.1363191-.0229565-.0189706c-1.43704227-1.2411241-2.34462949-3.045583-2.42083359-5.0285539l-.00520991-.2714755c0-3.8659932 3.1340068-7 7-7s7 3.1340068 7 7c0 1.9941317-.8415062 3.8279876-2.224566 5.1193683l-.225434.2006317.0447787.0163138c2.3268368.8792152 4.3570558 2.4138611 5.8430586 4.4127726 1.6098837-2.1632453 2.5621627-4.8449575 2.5621627-7.7490864 0-7.17970175-5.8202983-13-13-13z"/>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a>個人資料</a>
          </div>
        </a>
      </div>
    </div>
    <div class="LinkGroup col-10" v-else @click="changeLink">
      <div class="search default">
        <router-link to="/" class="text-decoration-none">
          <div class="col-12 linkItem">
            <a class="col-12">
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; fill: none; height: 24px; width: 24px; stroke: currentcolor; stroke-width: 4; overflow: visible;">
                <g fill="none">
                  <path
                      d="m13 24c6.0751322 0 11-4.9248678 11-11 0-6.07513225-4.9248678-11-11-11-6.07513225 0-11 4.92486775-11 11 0 6.0751322 4.92486775 11 11 11zm8-3 9 9"/>
                </g>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a class="col-12">首頁</a>
          </div>
        </router-link>
      </div>
      <div class="wish">
        <router-link to="/wishList" class="text-decoration-none">
          <div class="col-12 linkItem">
            <a>
              <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                   style="display: block; fill: none; height: 24px; width: 24px; stroke: currentcolor; stroke-width: 2.66667; overflow: visible;">
                <path
                    d="m16 28c7-4.733 14-10 14-17 0-1.792-.683-3.583-2.05-4.95-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05l-2.051 2.051-2.05-2.051c-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05-1.367 1.367-2.051 3.158-2.051 4.95 0 7 7 12.267 14 17z"/>
              </svg>
            </a>
          </div>
          <div class="col-12 linkItemText">
            <a>心願單</a>
          </div>
        </router-link>
      </div>
      <a href="/account/login" class="person text-decoration-none">
        <div class="col-12 linkItem">
          <a>
            <svg viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg" aria-hidden="true" focusable="false"
                 style="display: block; height: 24px; width: 24px; fill: currentcolor;">
              <path
                  d="m16 1c8.2842712 0 15 6.71572875 15 15 0 8.2842712-6.7157288 15-15 15-8.28427125 0-15-6.7157288-15-15 0-8.28427125 6.71572875-15 15-15zm0 8c-2.7614237 0-5 2.2385763-5 5 0 2.0143973 1.2022141 3.7998876 2.9996346 4.5835001l.0003231 2.0984999-.1499943.0278452c-2.8326474.5613112-5.31897338 2.2230336-6.93575953 4.5872979 2.34343054 2.291067 5.54974273 3.7028569 9.08579613 3.7028569 3.5355506 0 6.7414538-1.4113884 9.0850203-3.701476-1.6141801-2.3628535-4.0978119-4.0247647-6.929184-4.5867938l-.1558786-.0287302.001228-2.0991413c1.7288399-.7547474 2.9066959-2.4357565 2.9936498-4.355479l.0051645-.2283797c0-2.7614237-2.2385763-5-5-5zm0-6c-7.17970175 0-13 5.82029825-13 13 0 2.9045768.95257276 5.5866683 2.56235849 7.7509147 1.42074739-1.9134907 3.33951478-3.4002416 5.53860831-4.2955956l.3480332-.1363191-.0229565-.0189706c-1.43704227-1.2411241-2.34462949-3.045583-2.42083359-5.0285539l-.00520991-.2714755c0-3.8659932 3.1340068-7 7-7s7 3.1340068 7 7c0 1.9941317-.8415062 3.8279876-2.224566 5.1193683l-.225434.2006317.0447787.0163138c2.3268368.8792152 4.3570558 2.4138611 5.8430586 4.4127726 1.6098837-2.1632453 2.5621627-4.8449575 2.5621627-7.7490864 0-7.17970175-5.8202983-13-13-13z"/>
            </svg>
          </a>
        </div>
        <div class="col-12 linkItemText">
          <a>登入</a>
        </div>
      </a>
    </div>
  </div>
</template>

<script>
export default {
  methods: {
    changeLink() {
      document.querySelector('.search').classList.remove('default');
    },
    trip() {
      window.location.href = '/trip'
    }
  },
  mounted() {
    if (!document.querySelector('.search > a').getAttribute('class').includes('router-link-active')) {
      document.querySelector('.search').classList.remove('default')
    }
  }
}
</script>

<style scoped lang="scss">

#nav {
  text-align: center;
  padding: 0;
  position: fixed;
  bottom: 0% !important;
  background-color: #fff;
  z-index: 10;

  &.toggle {
    display: none;
    transition: .3s;
  }

  .LinkGroup {
    display: flex;
    justify-content: space-around;
    width: 100vw;
    margin: 0 !important;

    .search.default {
      svg {
        color: #ff385c;
      }

      .linkItemText {
        a {
          color: #000 !important;
        }
      }
    }

    .search, .wish, .trip, .email, .person {
      width: 20%;
      background-color: #fff;
      display: flex;
      flex-direction: column;
      height: 64px;
      justify-content: center;
      cursor: pointer;

      &:hover {
        .linkItem {
          a {
            color: #ff385c;
          }
        }

        .linkItemText {
          a {
            color: #222222;
          }
        }
      }

      .linkItem {
        a {
          display: flex;;
          color: #b0b0b0;
          justify-content: center;
        }
      }

      .linkItemText {
        a {
          margin-top: 0.4rem;
          display: block;
          font-weight: bold;
          color: #b0b0b0;
          text-decoration: none;
          width: 100%;
          white-space: nowrap;
        }
      }
    }

    .trip {
      width: 100%;
    }

    .person {
      width: 100%;
      
    }
  }

  .router-link-active {
    svg {
      color: #ff385c;
    }

    .linkItemText {
      a {
        color: #000 !important;
      }
    }
  }
}

@media screen and (min-width: 768px) {
  #nav {
    display: none;
  }
}
</style>