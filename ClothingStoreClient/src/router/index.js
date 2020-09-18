import Vue from "vue";
import Router from "vue-router";
import Home from "@/components/Home";
import NotFound from "@/components/NotFound";
import ProductList from "@/components/product/ProductList";
import ProductDetails from "@/components/product/ProductDetails";
import ProductCreate from "@/components/product/ProductCreate";
import ProductUpdate from "@/components/product/ProductUpdate";

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      path: "/",
      name: "Home",
      component: Home
    },
    {
      path: "/product/list",
      name: "ProductList",
      component: ProductList
    },
    {
      path: "/product/create",
      name: "ProductCreate",
      component: ProductCreate
    },
    {
      path: "/product/update/:id",
      name: "ProductUpdate",
      component: ProductUpdate
    },
    {
      path: "/product/:id",
      name: "ProductDetails",
      component: ProductDetails
    },
    {
      path: "*",
      name: "NotFound",
      component: NotFound
    }
  ]
});
