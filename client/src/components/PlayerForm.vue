<script setup>
import { playerService } from "@/services/PlayerService.js";
import { logger } from "@/utils/Logger.js";
import Pop from "@/utils/Pop.js";


async function addPlayer(){
  try {
    await playerService
  } catch (error) {
    Pop.toast("Could not add player", 'error')
    logger.error(error)
  }
}

</script>


<template>
<div class="container-fluid">
  <form @submit.prevent="addPlayer()" class="row">
    <div class="mb-3 col-10">
      <input type="text" class="form-control" id="player-name" placeholder="Name...">
    </div>
    <div class="col-2">
      <button class="btn btn-success text-white"><i class="mdi mdi-plus-thick"></i></button>
    </div>
  </form>
</div>
</template>


<style lang="scss" scoped>

</style>