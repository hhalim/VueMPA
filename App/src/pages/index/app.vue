<template>
  <div class="container page">
    <div class="row">
      <div class="col">
        <h1>Index Page</h1>
        <hello-world></hello-world>

        <p>Security token: {{token}}</p>
        <button class="btn btn-primary" @click="logoff">Logoff</button>
      </div>
    </div>
  </div>
</template>

<script>
  import HelloWorld from './components/hello-world.vue';

  export default {
    name: 'index',
    components: {
      HelloWorld
    },
    data() {
      return {
        token: ''
      }
    },
    mounted() {
      if (localStorage.token) {
        this.token = localStorage.token;
      }
    },
    methods: {
      logoff() {
        localStorage.token = '';
        this.token = '';
      }
    },
  }
</script>

<style scoped>
  .page {
  }
</style>