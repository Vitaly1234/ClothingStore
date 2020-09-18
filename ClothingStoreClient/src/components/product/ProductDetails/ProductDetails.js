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
  async created() {
    const response = await ProductService.get(
      this.$router.currentRoute.params.id
    );
    this.product = response.data;
    this.availableSizes = this.product.size.replace(/\s/g, "").split(",");
  }
};
