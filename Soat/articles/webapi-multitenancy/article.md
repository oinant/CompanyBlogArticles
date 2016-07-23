# Multi-tenancy Et Microsoft ASP.NET WebAPI 2

Alors que les systèmes Saas (Software As A Service) ont démocratisé la notion de multi-tenancy, qui permet à un système d'être exploité par plus d'une entité, l'évolution des principes de la SOA (Architecture Orienté Service) vers des systèmes de plus en plus distribué, via les microservices, marque l'avènement  des API REST.

Sur la stack .Net, ASP.NET WebAPI est le framework idéal pour monter une API REST multi-tenante. En effet, dans sa version 2, le framework intègre toutes les facilités nécessaires, qui nous permettent de créer des API capable des résoudre 3 des uses-cases les plus fréquents :

* Tous les tenants suivent les mêmes règles de gestion : use-case typique dans le cas d'un Saas
* Chaque tenant bénéficie d'un hebergement spéifique et nécessite une quantité importante de règles spécifiques : la multi-tenancy est alors liée à la mutualisation du code des différentes API déployées
* Tous les tenants sont utilisent la même infrastructure, mais nécessitent, pour des raisons légales par exemple, des régles de gestion spécifiques 


## Use-case 1 : Cas du Saas : 

Dans le cas d'un Saas, la première problématique commerciale est d'être capable de monitorer de gérer les accès à l'API par tenant.
Nous allons pouvoir bénéficier de l'attribut RoutePrefix de HttpController afin de mutualiser l'identification du compte du tenant dont provient l'appel.  

```c#
    [RoutePrefix("api/v1/{tenantId}/ping")]
    public class PingController : ApiController
    {
        [HttpGet, Route("")]
        public IHttpActionResult Ping(string tenantId)
        {
            return Ok(tenantId);
        }
    }
```

```HTTP
GET /api/v1/the_tenant_id/ping HTTP/1.1
Host: localhost:61450
Cache-Control: no-cache
```