<template>
  <div class="container page">
    <div class="row">
      <div class="col">
        <LoginForm></LoginForm>
      </div>
    </div>
  </div>
</template>

<script>
  import LoginForm from '../../../components/user/LoginForm.vue';

  export default {
    name: 'Login',
    components: {
      LoginForm
    },
  }
</script>

<style scoped>
  .page {
  }
</style>