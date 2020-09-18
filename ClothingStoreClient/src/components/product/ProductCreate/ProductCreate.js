import ProductService from "@/api-services/product.service";

export default {
  name: "ProductCreate",
  data() {
    return {
      formData: {
        name: "",
        description: "",
        arrived: "",
        availability: "InStock",
        type: "Outerwear",
        size: []
      },
      alertModalTitle: "",
      alertModalContent: "",
      isSuccessfully: false
    };
  },
  methods: {
    async createProduct() {
      const { size, ...data } = this.formData;
      data.size = size.length ? size.join(",") : null;
      data.arrived = data.arrived || null;
      data.description = data.description || null;
      try {
        await ProductService.create(data);

        this.isSuccessfully = true;
        this.alertModalTitle = "Success";
        this.alertModalContent = "Successfully created product";
        this.$refs.alertModal.show();
        this.formData = {
          name: "",
          description: "",
          arrived: "",
          availability: "OutStock",
          type: "Outerwear",
          size: ""
        };
      } catch (e) {
        this.isSuccessfully = false;
        this.alertModalTitle = "Error";
        this.alertModalContent = e.response.data;
        this.$refs.alertModal.show();
      }
    },
    onAlertModalOkClick() {
      if (this.isSuccessfully) {
        this.$router.push({ name: "ProductList" });
      }
    }
  }
};
