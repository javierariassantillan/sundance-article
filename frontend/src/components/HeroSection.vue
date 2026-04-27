<template>
  <section class="hero">
    <div class="hero-content">
      <p class="breadcrumb">{{ article.breadcrumb }}</p>
      <h1>{{ article.title }}</h1>
      <p class="author">{{ article.author }}</p>
    </div>

    <div class="hero-image"></div>
  </section>
</template>

<script setup>
defineProps({
  article: {
    type: Object,
    required: true
  }
})
</script>

<style scoped>
.hero {
  min-height: 430px;
  display: grid;
  grid-template-columns: 46% 54%;
  background: #d7edf8;
}

.hero-content {
  padding: 72px 48px;
}

.breadcrumb,
.author {
  color: #0d2d46;
  font-weight: 700;
}

.breadcrumb {
  margin-bottom: 24px;
  font-size: 14px;
}

h1 {
  max-width: 520px;
  margin: 0 0 24px;
  color: #0d2d46;
  font-size: clamp(38px, 4.2vw, 58px);
  line-height: 1;
  letter-spacing: -1.6px;
}

.hero-image {
  background:
    linear-gradient(135deg, rgba(13, 45, 70, 0.1), rgba(13, 45, 70, 0.45)),
    linear-gradient(135deg, #d9e7ed, #7898a8);
}

@media (max-width: 900px) {
  .hero {
    grid-template-columns: 1fr;
  }

  .hero-content {
    padding: 44px 24px;
  }

  .hero-image {
    min-height: 220px;
  }
}
</style>