import { createRouter, createWebHistory } from 'vue-router'

import DashboardView from '../views/DashboardView.vue'
import UserView from '../views/UserView.vue'

const router = createRouter({
  history: createWebHistory(),

  routes: [
    {
      path: '/',
      component: DashboardView,
    },

    {
      path: '/users',
      component: UserView,
    },
  ],
})

export default router