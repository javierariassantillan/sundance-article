<template>
  <section class="content-section">
    <h2>Explore Spas</h2>

    <div class="card-grid">
      <article v-for="spa in spas" :key="spa.name" class="spa-card">
        <div class="spa-image"></div>

        <small>{{ spa.series }}</small>
        <h3>{{ spa.name }}</h3>

        <p class="seats">Seating: {{ spa.seats }} Lounge Seat</p>
        <p class="features">{{ spa.features.join(' · ') }}</p>

        <div class="card-footer">
          <strong>{{ spa.price }}</strong>
          <button>See Price Now</button>
        </div>
      </article>
    </div>
  </section>
</template>

<script setup>
defineProps({
  spas: {
    type: Array,
    required: true
  }
})
</script>

<style scoped>
.content-section {
  max-width: 1120px;
  margin: 88px auto;
  padding: 0 24px;
}

h2 {
  margin-bottom: 34px;
  color: #0d2d46;
  font-size: 40px;
  text-align: center;
}

.card-grid {
  display: grid;
  grid-template-columns: repeat(3, minmax(0, 1fr));
  gap: 24px;
}

.spa-card {
  overflow: hidden;
  padding: 22px;
  background: #ffffff;
  border-radius: 14px;
  box-shadow: 0 10px 28px rgba(13, 45, 70, 0.1);
}

.spa-image {
  height: 145px;
  margin: -22px -22px 20px;
  background:
    linear-gradient(135deg, rgba(13, 45, 70, 0.1), rgba(13, 45, 70, 0.45)),
    linear-gradient(135deg, #d9e7ed, #7898a8);
}

small {
  color: #0d2d46;
  font-weight: 700;
}

h3 {
  margin: 8px 0 12px;
  color: #0d2d46;
  font-size: 26px;
}

.seats {
  font-weight: 700;
}

.features {
  min-height: 52px;
  color: #5f6f7a;
}

.card-footer {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 16px;
  margin-top: 18px;
}

button {
  border: 0;
  background: transparent;
  color: #0d2d46;
  font-weight: 700;
  text-decoration: underline;
  cursor: pointer;
}

@media (max-width: 900px) {
  .card-grid {
    grid-template-columns: 1fr;
  }

  h2 {
    text-align: left;
    font-size: 32px;
  }
}

@media (max-width: 520px) {
  .card-footer {
    align-items: flex-start;
    flex-direction: column;
  }
}
</style>