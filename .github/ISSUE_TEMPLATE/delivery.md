---
name: Delivery
about: Create a new Delivery report issue
title: "[DEL] "
labels: delivery, origin/meo
assignees: ''

---

## Description
A clear and concise description of what this delivery report is about.
## Delivery repository
A reference to the customer and BU delivery repository. Example:
[customer-bu](https://github.com/AlticeLabsProjects/customer-bu)

## Delivery Products and Solutions
Describe some details about the delivered artifacts. Example: 
| Product/Solution  Repository  | Release and Release Notes |
:---------------------------------|:------------------------------|
| [cicd-service repo](https://github.com/AlticeLabsProjects/cicd-service)| [cicd-service release](https://github.com/AlticeLabsProjects/cicd-service/releases/tag/v1.0.17) |

## Delivery environment
Description or link to the environment(s) of the release. Example: 
| Environment| Description/Link |
:---------------------------------|:------------------------------|
| QA | [GKE QA cluster](https://console.cloud.google.com/kubernetes/clusters/details/europe-west1-b/cicd-dev/details?project=cicd-328412)|
| PROD | [GKE PROD cluster](https://console.cloud.google.com/kubernetes/clusters/details/europe-west1/cicd-ha/details?project=cicd-328412)|

## Issues
### Delivery incidents
Reference to related Delivery Incidents issues.

## Additional context
Add any other context about the proposed enhancement.

## Attachments
If applicable, add attachments to help explain the new enhancement.
