module.exports = {
    content: [
        './Gest.UI/**/*.razor',
        './Gest.Web/**/*.cshtml',
    ],
  theme: {
    extend: {},
  },
    plugins: [require("@tailwindcss/typography"), require("daisyui")]
}
