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
    createProduct() {
      const { size, ...data } = this.formData;
      data.size = size.length ? size.join(",") : null;
      data.arrived = data.arrived ? arrived : null;
      data.description = data.description ? data.description : null;
      ProductService.create(data)
        .then(() => {
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
        })
        .catch(error => {
          this.isSuccessfully = false;
          this.alertModalTitle = "Error";
          this.alertModalContent = error.response.data;
          this.$refs.alertModal.show();
        });
    },
    onAlertModalOkClick() {
      if (this.isSuccessfully) {
        this.$router.push({ name: "ProductList" });
      }
    }
  }
};
