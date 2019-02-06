import Vue from 'vue';
import App from './app.vue';
import Toasted from 'vue-toasted';
import Mixin from '../../Mixin';
import axios from 'axios';

axios.defaults.withCredentials = true;
Vue.config.productionTip = false;

Vue.use(Toasted, {
    iconPack : 'fontawesome' // set your iconPack, defaults to material. material|fontawesome|custom-class
});
Vue.mixin(Mixin); //needed for Version and Toasted to work easily

axios.defaults.withCredentials = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
