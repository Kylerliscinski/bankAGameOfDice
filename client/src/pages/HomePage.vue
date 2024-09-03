<script setup>
import PlayerForm from "@/components/PlayerForm.vue";



</script>

<template>
  <section class="container-fluid">
    <div class="row justify-content-center">
    
    <div class="text-center mb-3 col-12">
      <h1>Bank!</h1>
    </div>
    
    
      <div class="col-12 col-md-4">
        <div class="card">
          <h3 class="px-2 pt-3 text-center">Add your Players</h3>
          <hr>
          <PlayerForm/>
        </div>
      </div>
    </div>
    
  </section>
</template>

<style scoped lang="scss">
.home {
  display: grid;
  height: 80vh;
  place-content: center;
  text-align: center;
  user-select: none;

  .home-card {
    width: clamp(500px, 50vw, 100%);

    >img {
      height: 200px;
      max-width: 200px;
      width: 100%;
      object-fit: contain;
      object-position: center;
    }
  }
}
</style>
