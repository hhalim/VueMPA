<template>
  <div class="container page">
    <div class="row">
      <div class="col">
        <h1>User Page</h1>
        <p>{{username}}</p>
        <p>Security token: {{token}}</p>
        <button class="btn btn-primary" @click="logoff">Logoff</button>
      </div>
    </div>
  </div>
</template>

<script>
  import axios from 'axios';

  export default {
    name: 'User',
    data() {
      return {
        token: '',
        apiRoot: process.env.VUE_APP_API_ROOT,
        username: null
      }
    },
    mounted() {
      if (localStorage.token) {
        this.token = localStorage.token;
      }

      axios.get(this.apiRoot + 'user/getUsername')
        .then(response => {
          this.username = response.data;
        })
        .catch((err) => {
          this.$toasted.show('Error. ' + err.message, this.toastError);
        });
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