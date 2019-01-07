import Vue from 'vue';
import VueRouter from 'vue-router';

import Main from "./components/Pages/Main.vue"
import Search from "./components/Pages/Search.vue"
Vue.use(VueRouter);

const routes = [
    {
        path: "/",
        component: Main,
        name:"main"
    },
    {
        path: "/search/",
        component: Search,
        name:"search"
    },
];

new Vue({
    el: '#app-root',
    router: new VueRouter({ mode: 'history', routes: routes }),
    render: h => h(require('./components/App.vue'))
});
