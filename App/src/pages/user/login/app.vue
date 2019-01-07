<template>
  <div class="container page">
    <div class="row">
      <div class="col">
        <login-form></login-form>
      </div>
    </div>
  </div>
</template>

<script>
  import LoginForm from '../../../components/user/login-form.vue';

  export default {
    name: 'app',
    components: {
      LoginForm
    },
  }
</script>

<style scoped>
  .page {
  }
</style>