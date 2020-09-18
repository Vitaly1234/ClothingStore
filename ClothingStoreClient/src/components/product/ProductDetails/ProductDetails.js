import ProductService from "@/api-services/product.service";

export default {
  name: "ProductDetails",
  data() {
    return {
      product: {},
      availableSizes: []
    };
  },
  computed: {
    arrivedDate() {
      return this.product && this.product.arrived
        ? new Date(this.product.arrived).toLocaleDateString()
        : "";
    }
  },
  created() {
    ProductService.get(this.$router.currentRoute.params.id).then(response => {
      this.product = response.data;
      this.availableSizes = this.product.size.replace(/\s/g, "").split(",");
    });
  }
};
