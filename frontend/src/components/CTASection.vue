<template>
  <section class="dealer">
    <div class="dealer-image"></div>

    <div class="dealer-content">
      <h2>Visit a Sundance Spas Showroom Near You</h2>
      <p>
        Take advantage of exclusive dealer services and offers by visiting your local dealer today.
      </p>
      <button>Find a Dealer</button>
    </div>
  </section>
</template>

<style scoped>
.dealer {
  max-width: 1120px;
  margin: 84px auto;
  display: grid;
  grid-template-columns: 42% 58%;
  overflow: hidden;
  border-radius: 10px;
  background: #0d2d46;
  color: #ffffff;
}

.dealer-image {
  min-height: 260px;
  background:
    linear-gradient(135deg, rgba(13, 45, 70, 0.1), rgba(13, 45, 70, 0.45)),
    linear-gradient(135deg, #d9e7ed, #7898a8);
}

.dealer-content {
  padding: 48px;
}

h2 {
  max-width: 520px;
  margin: 0 0 14px;
  font-size: 38px;
  line-height: 1.08;
}

p {
  max-width: 540px;
  margin-bottom: 24px;
  color: #dce8ee;
}

button {
  border: 0;
  border-radius: 999px;
  padding: 11px 22px;
  background: #ffffff;
  color: #0d2d46;
  font-weight: 700;
  cursor: pointer;
}

@media (max-width: 900px) {
  .dealer {
    grid-template-columns: 1fr;
    margin: 56px 24px;
  }

  .dealer-content {
    padding: 32px 24px;
  }

  h2 {
    font-size: 31px;
  }
}
</style>