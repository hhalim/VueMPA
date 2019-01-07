<template>
  <form id="loginForm" @submit.prevent="onSubmit" class="mt-3">
    <div class="form-group">
      <label for="username">Username</label>
      <input type="text" class="form-control" id="username" name="username" v-model="username" placeholder="Enter username">
    </div>
    <div class="form-group">
      <label for="password">Password</label>
      <input type="password" class="form-control" id="password" name="password" v-model="password" placeholder="Password">
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
  </form>
</template>

<script>
  import axios from 'axios';
  import serialize from 'form-serialize-json';

  export default {
    name: 'login-form',
    data() {
      return {
        username: '',
        password: '',
        apiRoot: process.env.VUE_APP_API_ROOT,
      }
    },
    methods: {
      onSubmit() {
        let api = this.apiRoot + '/user/login';
        let form = document.querySelector('#loginForm');
        var data = serialize(form);
        console.log(data);
        axios.post(api, data)
          .then(response => {
            console.log(response.data);
            localStorage.token = response.data;
            alert('Login successful, token: ' + response.data);
          })
          .catch((err) => {
            alert('Error. ' + err.message);
          });

      }
    }
  }
</script>

<style scoped>
</style>