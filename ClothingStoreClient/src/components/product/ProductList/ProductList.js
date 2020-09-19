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
      searchTerm: "",
      totalPages: 1,
      currentPage: 1,
      pageSize: 20,
      hasNext: false,
      hasPrevious: false,
      orderByStr: "",
      columns: [
        { displayName: "Product name", name: "name", order: 0 },
        { displayName: "Availability", name: "availability", order: 0 },
        { displayName: "Type", name: "type", order: 0 },
        { displayName: "Available sizes", name: "size", order: 0 }
      ]
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
      try {
        const response = await ProductService.getAll(
          this.searchTerm,
          this.currentPage,
          this.pageSize,
          this.orderByStr
        );
        this.products = response.data;
        this.products.forEach(x => {
          x.arrived = new Date(x.arrived).toLocaleDateString();
        });
        const paginationData = JSON.parse(response.headers["x-pagination"]);
        this.totalPages = paginationData.totalPages;
        this.hasNext = paginationData.hasNext;
        this.hasPrevious = paginationData.hasPrevious;
        this.currentPage = paginationData.currentPage;
      } catch (e) {
        this.alertModalTitle = "Error";
        this.alertModalContent = e.message;
        this.$refs.alertModal.show();
      } finally {
        this.isLoading = false;
      }
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
    },
    onPageEnter(e) {
      const currentValue = parseInt(e.target.value);
      if (currentValue < 1) {
        this.currentPage = 1;
      } else if (currentValue > this.totalPages) {
        this.currentPage = this.totalPages;
      }
      this.fetchProducts();
    },
    nextPage: function() {
      this.currentPage++;
      this.fetchProducts();
    },
    prevPage: function() {
      this.currentPage--;
      this.fetchProducts();
    },
    sort(columnName) {
      const currentColumn = this.columns.find(x => x.name === columnName);
      currentColumn.order =
        currentColumn.order === 0 ? 1 : currentColumn.order === 1 ? -1 : 0;
      this.orderByStr = this.columns
        .filter(x => x.order !== 0)
        .reduce(
          (acc, item) =>
            (acc += `${item.name} ${item.order > 0 ? "asc" : "desc"},`),
          ""
        )
        .slice(0, -1);
      this.fetchProducts();
    }
  },
  created() {
    this.fetchProducts();
  }
};
