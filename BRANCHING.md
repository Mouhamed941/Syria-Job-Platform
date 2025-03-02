# Branching Strategy

## Main Branches
- `main` - Production-ready code
- `develop` - Latest development code

## Supporting Branches
- `feature/feature-name` - For new features
- `bugfix/bug-description` - For bug fixes
- `hotfix/issue-description` - For urgent production fixes

## Workflow
1. Create feature branches from `develop`
2. When feature is complete, merge back to `develop`
3. Release candidates come from `develop`
4. Hotfixes branch from `main` and merge to both `main` and `develop`
