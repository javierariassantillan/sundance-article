<template>
  <section class="content-section">
    <h2>Related Articles</h2>

    <div class="card-grid">
      <article v-for="article in articles" :key="article" class="related-card">
        <div class="related-image"></div>
        <small>Buying Guides</small>
        <h3>{{ article }}</h3>
      </article>
    </div>
  </section>
</template>

<script setup>
defineProps({
  articles: {
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

.related-card {
  overflow: hidden;
  padding-bottom: 20px;
  background: #ffffff;
  border-radius: 14px;
  box-shadow: 0 10px 28px rgba(13, 45, 70, 0.1);
}

.related-image {
  height: 150px;
  margin-bottom: 18px;
  background:
    linear-gradient(135deg, rgba(13, 45, 70, 0.1), rgba(13, 45, 70, 0.45)),
    linear-gradient(135deg, #d9e7ed, #7898a8);
}

small,
h3 {
  display: block;
  padding: 0 20px;
}

small {
  color: #0d2d46;
  font-weight: 700;
}

h3 {
  color: #0d2d46;
  font-size: 21px;
  line-height: 1.25;
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
</style>