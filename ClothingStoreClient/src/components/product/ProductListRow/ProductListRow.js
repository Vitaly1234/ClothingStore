export default {
  name: "ProductListRow",
  props: {
    product: {
      type: Object,
      required: true
    }
  },
  methods: {
    onDetails() {
      this.$emit("details", this.product.id);
    },
    onUpdate() {
      this.$emit("update", this.product.id);
    },
    onDelete() {
      this.$emit("delete", this.product.id);
    }
  }
};
