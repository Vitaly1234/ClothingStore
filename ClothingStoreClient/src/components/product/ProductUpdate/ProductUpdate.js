import ProductService from "@/api-services/product.service";

export default {
  name: "ProductUpdate",
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
  created() {
    ProductService.get(this.$router.currentRoute.params.id).then(response => {
      const { size, arrived, ...data } = response.data;
      data.size = response.data.size
        ? response.data.size.replace(/\s/g, "").split(",")
        : [];
      data.arrived = arrived
        ? new Date(response.data.arrived)
            .toLocaleDateString("ru-RU")
            .replace(/\./g, "-")
            .split("-")
            .reverse()
            .join("-")
        : "";
      this.formData = data;
    });
  },
  methods: {
    updateProduct() {
      const { size, ...data } = this.formData;
      data.size = size.length ? size.join(",") : null;
      data.arrived = data.arrived ? arrived : null;
      data.description = data.description ? data.description : null;
      ProductService.update(this.$router.currentRoute.params.id, data)
        .then(() => {
          this.isSuccessfully = true;
          this.alertModalTitle = "Success";
          this.alertModalContent = "Successfully updated product";
          this.$refs.alertModal.show();
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
