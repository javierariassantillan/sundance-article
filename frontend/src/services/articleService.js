export async function getArticle() {
  const response = await fetch('http://localhost:5082/api/article')
  return await response.json()
}