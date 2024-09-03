<script setup>
import { onMounted } from 'vue';

onMounted(() => {
  
})


</script>

<template>
  <nav class="bg-dark p-2">
      <div class="d-flex flex-column align-items-center">
        <img alt="logo" src="https://t3.ftcdn.net/jpg/08/27/31/00/360_F_827310016_KPLq11KeUXVW7rwVwG85TqeKEPtS09VT.jpg" height="45" />
      </div>
  </nav>
</template>

<style scoped>
a:hover {
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 2px solid var(--bs-success);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

@media screen and (min-width: 576px) {
  nav {
    height: 64px;
  }
}
</style>
