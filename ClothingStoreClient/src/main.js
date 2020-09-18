// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from "vue";
import BootstrapVue from "bootstrap-vue";
import App from "./components/App";
import router from "./router";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
import Axios from "axios";
import "./assets/main.scss";

Vue.config.productionTip = false;
Axios.defaults.baseURL = process.env.API_ENDPOINT;
Vue.use(BootstrapVue);
Vue.mixin({
  data() {
    return {
      availabilityArr: ["OutStock", "InStock", "Order"],
      typeArr: ["Outerwear", "Underwear", "Accessory", "Footwear", "Other"],
      sizeArr: ["XS", "S", "M", "L", "XL"]
    };
  }
});
new Vue({
  el: "#app",
  router,
  template: "<App/>",
  components: {
    App
  }
});
