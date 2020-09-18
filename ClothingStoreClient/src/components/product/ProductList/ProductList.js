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
      alertModalContent: ""
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
    fetchProducts() {
      ProductService.getAll().then(response => {
        this.products = response.data;
        this.products.forEach(x => {
          x.arrived = new Date(x.arrived).toLocaleDateString();
        });
      });
    },
    onDeleteConfirm() {
      ProductService.delete(this.selectedProductId)
        .then(() => {
          this.alertModalTitle = "Success";
          this.alertModalContent = "Successfully deleted product";
          this.$refs.alertModal.show();
          this.fetchProducts();
        })
        .catch(error => {
          this.alertModalTitle = "Error";
          this.alertModalContent = error.response.data;
          this.$refs.alertModal.show();
        });
    },
    onDeleteModalHide() {
      this.selectedProductId = null;
    }
  },
  created() {
    this.fetchProducts();
  }
};
