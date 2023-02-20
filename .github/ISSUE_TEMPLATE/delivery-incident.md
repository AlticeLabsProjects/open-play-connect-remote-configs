---
name: Delivery Incident
about: Create a new Delivery Incident report issue
title: "[DEL_INCIDENT] "
labels: delivery/incident, origin/meo
assignees: ''

---

## Description
A clear and concise description of what this delivery incident report is about.

## Incident Details
A comprehensive description about the reported incident.
 
## Issues
### Delivery 
Reference to affected Delivery report issues.

## Affected Products and Solutions
Describe some details about the affected artifacts by this incident. Example: 
| Product/Solution  Repository  | Release and Release Notes |
:---------------------------------|:------------------------------|
| [cicd-service repo](https://github.com/AlticeLabsProjects/cicd-service)| [cicd-service v1.0.17 release](https://github.com/AlticeLabsProjects/cicd-service/releases/tag/v1.0.17) |

## Delivery incident environment
Description or link to the environment(s) affected by this incident. Example: 
| Environment| Description/Link |
:---------------------------------|:------------------------------|
| QA | [GKE QA cluster](https://console.cloud.google.com/kubernetes/clusters/details/europe-west1-b/cicd-dev/details?project=cicd-328412)|
| PROD | [GKE PROD cluster](https://console.cloud.google.com/kubernetes/clusters/details/europe-west1/cicd-ha/details?project=cicd-328412)|

## Additional context
Add any other context about the proposed enhancement.

## Attachments
If applicable, add attachments to help explain the new enhancement.
