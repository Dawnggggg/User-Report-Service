<template>
  <v-app>

    <!-- SIDEBAR -->
    <v-navigation-drawer
      app
      color="indigo-darken-4"
      theme="dark"
    >
      <div class="pa-5 text-center">

        <v-avatar
          size="70"
          color="white"
        >
          <v-icon
            size="40"
            color="indigo-darken-4"
          >
            mdi-store
          </v-icon>
        </v-avatar>

        <h2 class="mt-4">
          Sales Dashboard
        </h2>

        <p class="text-caption">
          Hệ thống Microservice
        </p>

      </div>

      <v-divider />

      <v-list nav>

        <v-list-item
          prepend-icon="mdi-view-dashboard"
          title="Tổng quan"
        />

        <v-list-item
          prepend-icon="mdi-account-group"
          title="Người dùng"
        />

        <v-list-item
          prepend-icon="mdi-cart"
          title="Đơn hàng"
        />

        <v-list-item
          prepend-icon="mdi-warehouse"
          title="Kho hàng"
        />

        <v-list-item
          prepend-icon="mdi-chart-line"
          title="Báo cáo"
        />

      </v-list>

    </v-navigation-drawer>

    <!-- HEADER -->
    <v-app-bar
      app
      color="white"
      elevation="1"
    >

      <v-app-bar-title>
        Hệ thống quản lý bán hàng & kho hàng
      </v-app-bar-title>

      <v-spacer />

      <v-btn icon>
        <v-icon>
          mdi-bell-outline
        </v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>
          mdi-account-circle
        </v-icon>
      </v-btn>

    </v-app-bar>

    <!-- MAIN -->
    <v-main class="bg-grey-lighten-4">

      <v-container
        fluid
        class="pa-5"
      >

        <v-row>

          <!-- USERS -->
          <v-col cols="12" md="3">

            <v-card class="pa-5 rounded-xl">

              <div class="d-flex justify-space-between">

                <div>

                  <p class="text-grey">
                    Người dùng
                  </p>

                  <h2>
                    1,245
                  </h2>

                </div>

                <v-avatar color="blue-lighten-4">

                  <v-icon color="blue">
                    mdi-account-group
                  </v-icon>

                </v-avatar>

              </div>

            </v-card>

          </v-col>

          <!-- ORDERS -->
          <v-col cols="12" md="3">

            <v-card class="pa-5 rounded-xl">

              <div class="d-flex justify-space-between">

                <div>

                  <p class="text-grey">
                    Đơn hàng
                  </p>

                  <h2>
                    3,820
                  </h2>

                </div>

                <v-avatar color="green-lighten-4">

                  <v-icon color="green">
                    mdi-cart
                  </v-icon>

                </v-avatar>

              </div>

            </v-card>

          </v-col>

          <!-- PRODUCTS -->
          <v-col cols="12" md="3">

            <v-card class="pa-5 rounded-xl">

              <div class="d-flex justify-space-between">

                <div>

                  <p class="text-grey">
                    Sản phẩm
                  </p>

                  <h2>
                    950
                  </h2>

                </div>

                <v-avatar color="orange-lighten-4">

                  <v-icon color="orange">
                    mdi-package-variant
                  </v-icon>

                </v-avatar>

              </div>

            </v-card>

          </v-col>

          <!-- REVENUE -->
          <v-col cols="12" md="3">

            <v-card class="pa-5 rounded-xl">

              <div class="d-flex justify-space-between">

                <div>

                  <p class="text-grey">
                    Doanh thu
                  </p>

                  <h2>
                    $58K
                  </h2>

                </div>

                <v-avatar color="deep-purple-lighten-4">

                  <v-icon color="deep-purple">
                    mdi-cash
                  </v-icon>

                </v-avatar>

              </div>

            </v-card>

          </v-col>

        </v-row>

      </v-container>

    </v-main>

  </v-app>
</template>