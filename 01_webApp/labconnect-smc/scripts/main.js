import { Router } from "svelte-spa-router";
import { routes } from "./routes.js";

const app = new Router({
  target: document.body,
  routes,
});

export default app;
