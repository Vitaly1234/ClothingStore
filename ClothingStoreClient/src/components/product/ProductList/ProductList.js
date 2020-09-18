import ProductService from "@/api-services/product.service";
import ProductListRow from "@/components/product/ProductListRow";

export default {
  name: "ProductList",
  components: {
    ProductListRow
  },
  data() {
    return {
      products: [],
      selectedProductId: null,
      alertModalTitle: "",
      alertModalContent: "",
      isLoading: false,
      searchTerm: ""
    };
  },
  methods: {
    detailsProduct(productId) {
      this.$router.push({ name: "ProductDetails", params: { id: productId } });
    },
    updateProduct(productId) {
      this.$router.push({ name: "ProductUpdate", params: { id: productId } });
    },
    deleteProduct(productId) {
      this.selectedProductId = productId;
      this.$refs.deleteConfirmModal.show();
    },
    async fetchProducts() {
      this.isLoading = true;
      const response = await ProductService.getAll(this.searchTerm);
      this.products = response.data;
      this.products.forEach(x => {
        x.arrived = new Date(x.arrived).toLocaleDateString();
      });
      this.isLoading = false;
    },
    async onDeleteConfirm() {
      try {
        await ProductService.delete(this.selectedProductId);
        this.alertModalTitle = "Success";
        this.alertModalContent = "Successfully deleted product";
        this.$refs.alertModal.show();
        this.fetchProducts();
      } catch (e) {
        this.alertModalTitle = "Error";
        this.alertModalContent = e.response.data;
        this.$refs.alertModal.show();
      }
    },
    onDeleteModalHide() {
      this.selectedProductId = null;
    }
  },
  created() {
    this.fetchProducts();
  }
};
