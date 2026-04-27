<template>
  <header class="header">
    <strong class="logo">Sundance® Spas</strong>

    <nav class="menu">
      <a>Our Spas</a>
      <a>Shop By Lifestyle</a>
      <a>Why Sundance</a>
      <a>Learn</a>
      <a>Get a Brochure</a>
    </nav>

    <button>Find a Dealer</button>
  </header>
</template>

<style scoped>
.header {
  height: 64px;
  padding: 0 48px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  background: white;
}

.logo {
  font-weight: bold;
  color: #0d2d46;
}

.menu {
  display: flex;
  gap: 24px;
  font-size: 14px;
}

button {
  background: #0d2d46;
  color: white;
  border: none;
  padding: 10px 18px;
  border-radius: 999px;
  cursor: pointer;
}

@media (max-width: 900px) {
  .menu {
    display: none;
  }
}

@media (max-width: 520px) {
  button {
    display: none;
  }
}
</style>