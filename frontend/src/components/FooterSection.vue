<template>
  <footer class="footer">
    <div class="footer-actions">
      <span>Brochure Download</span>
      <span>Locate a Dealer</span>
      <span>Get a Quote</span>
      <span>Buyer’s Guide</span>
    </div>

    <div class="footer-columns">
      <div>
        <h4>Support</h4>
        <p>Customer Service</p>
        <p>FAQs</p>
        <p>Financing</p>
      </div>

      <div>
        <h4>About</h4>
        <p>Manuals & Guides</p>
        <p>Warranty Coverage</p>
        <p>Product Registration</p>
      </div>

      <div>
        <h4>Company</h4>
        <p>Our Promise to You</p>
        <p>Learning Hub</p>
        <p>Careers</p>
      </div>

      <div>
        <h4>Partners</h4>
        <p>Become a Dealer</p>
        <p>Canada Report S211</p>
      </div>
    </div>

    <small>USA | English · © 2025 Sundance® Spas Inc. · Privacy Policy · Terms of Use</small>
  </footer>
</template>

<style scoped>
.footer {
  padding: 46px 48px 34px;
  background: #0d2d46;
  color: #ffffff;
}

.footer-actions,
.footer-columns {
  display: grid;
  max-width: 1120px;
  margin: 0 auto;
}

.footer-actions {
  grid-template-columns: repeat(4, 1fr);
  gap: 14px;
  padding-bottom: 32px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.25);
  font-weight: 700;
}

.footer-columns {
  grid-template-columns: repeat(4, 1fr);
  gap: 36px;
  padding: 32px 0;
}

h4 {
  margin: 0 0 12px;
}

p {
  margin: 8px 0;
  color: #dce8ee;
}

small {
  display: block;
  max-width: 1120px;
  margin: 0 auto;
  color: #dce8ee;
}

@media (max-width: 900px) {
  .footer,
  .footer-actions,
  .footer-columns {
    grid-template-columns: 1fr;
  }

  .footer {
    padding: 38px 24px;
  }
}
</style>