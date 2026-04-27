<template>
  <main v-if="article" class="page">
    <AppHeader />
    <HeroSection :article="article" />
    <ArticleContent :article="article" />
    <SpaSection :spas="article.spas" />
    <CTASection />
    <RelatedArticles :articles="article.relatedArticles" />
    <FooterSection />
  </main>

  <p v-else class="loading">Cargando artículo...</p>
</template>

<script setup>
import { onMounted, ref } from 'vue'

import AppHeader from './components/AppHeader.vue'
import HeroSection from './components/HeroSection.vue'
import ArticleContent from './components/ArticleContent.vue'
import SpaSection from './components/SpaSection.vue'
import CTASection from './components/CTASection.vue'
import RelatedArticles from './components/RelatedArticles.vue'
import FooterSection from './components/FooterSection.vue'

import { getArticle } from './services/articleService'

const article = ref(null)

onMounted(async () => {
  try {
    article.value = await getArticle()
  } catch (error) {
    console.error('No se pudo cargar el artículo:', error)
  }
})
</script>