---
title: Docker
---

```/bin/sh
docker run -v $(pwd):/target -v /var/run/docker.sock:/var/run/docker.sock automotivemastermind/condo:latest condo -- /t:publish
```
