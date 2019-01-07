<template>
  <div class="container page">
    <div class="row">
      <div class="col">
        <h1>User Page</h1>
        <p>Security token: {{token}}</p>
        <button class="btn btn-primary" @click="logoff">Logoff</button>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    name: 'user',
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
    font-size: large;
  }
    .page a {
      color: inherit;
    }
</style>