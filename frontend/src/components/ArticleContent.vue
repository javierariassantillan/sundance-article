<template>
  <article class="article">
    <h2>{{ article.introTitle }}</h2>
    <p class="lead">{{ article.intro }}</p>
    <p>{{ article.summary }}</p>

    <section v-for="section in article.sections" :key="section.title" class="article-section">
      <h2>{{ section.title }}</h2>

      <ol>
        <li v-for="item in section.items" :key="item">
          {{ item }}
        </li>
      </ol>
    </section>

    <blockquote>
      {{ article.quote }}
    </blockquote>

    <section class="article-section">
      <h2>{{ article.conclusionTitle }}</h2>
      <p>{{ article.conclusion }}</p>
    </section>
  </article>
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
.article {
  max-width: 760px;
  margin: 64px auto;
  padding: 0 24px;
  line-height: 1.75;
}

h2 {
  margin: 38px 0 14px;
  color: #0d2d46;
  font-size: 26px;
}

p,
li {
  color: #34444e;
}

.lead {
  font-size: 18px;
  color: #5f6f7a;
}

ol {
  padding-left: 22px;
}

li {
  margin-bottom: 14px;
}

blockquote {
  margin: 48px 0;
  padding: 28px 34px;
  border-left: 6px solid #0d2d46;
  background: #ffffff;
  color: #0d2d46;
  font-size: 22px;
  font-style: italic;
  line-height: 1.55;
}

@media (max-width: 520px) {
  h2 {
    font-size: 23px;
  }

  blockquote {
    padding: 22px;
    font-size: 18px;
  }
}
</style>