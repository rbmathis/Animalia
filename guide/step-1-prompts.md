# 📝 Step 1: Planning copilot-instructions.md Updates

> This guide documents the prompts used to plan enhancements to `.github/copilot-instructions.md` for better Copilot awareness of the repository's scale and structure.

---

## 🎯 Prompt 1 — Analyze & Plan

**Mode:** Plan Mode

> *"Read and understand the README.md. Plan to update copilot-instructions so that it is aware of the size/scope/breadth of the repo."*

### Result

![GitHub Copilot chat session showing a plan to update copilot-instructions.md with repository scale context. The chat displays the assistant reading README.md and copilot-instructions.md, then producing a structured plan with steps including adding a Repository Scale section with concrete stats such as 161,663 files and 3.8M lines, adding performance-aware guidance to the Copilot Tips section, and removing redundant mentions of 160,000+ species files. The plan includes verification steps and decisions about placement and tone. The interface uses a dark theme typical of VS Code.](image.png)

---

## 💡 Prompt 2 — Expand Recommendations

**Mode:** Plan Mode

> *"Recommend more items/strategies to add to instructions"*

### Result (Part 1)

![GitHub Copilot chat session in VS Code dark theme showing research findings and recommended additions to copilot-instructions.md. The assistant lists several strategies to enhance Copilot effectiveness in the large Animalia taxonomy repository. Recommendations include adding a Common Tasks and Patterns section with examples for adding new species, modifying genus hierarchies, and bulk operations. A Code Generation Guidelines section suggests namespace conventions matching folder paths, inheritance patterns like species extending genus classes, and required interface implementations. A Naming Conventions section covers file naming such as Genus_species.cs, class naming matching file names, and interface naming as IGenusName. A Conservation Status Reference section lists valid IUCN values: LC for Least Concern, NT for Near Threatened, VU for Vulnerable, EN for Endangered, CR for Critically Endangered, EW for Extinct in the Wild, and EX for Extinct. Additional recommendations include Search Strategy Tips for navigating 161K files efficiently using TaxId lookups and taxonomic path patterns, and a Testing Patterns section. The tone is informational and structured, presented as a bulleted list in the Copilot chat panel.](image-1.png)

### Result (Part 2)

![GitHub Copilot chat session continuing in VS Code dark theme, displaying additional recommended additions to copilot-instructions.md for the Animalia taxonomy repository. The assistant suggests adding a Performance Considerations section advising Copilot to avoid loading entire directories due to the 161K file scale, recommending targeted file access by species name or TaxId, and suggesting batch operations for bulk changes. A Cross-Reference Patterns section explains how to navigate between related files such as finding all species in a genus by listing files in the genus folder, locating parent classes by checking the folder above, and linking to NCBI using TaxId values. An Architecture Decisions section notes that abstract classes are used at every rank above species, interfaces define behavioral contracts at each taxonomic level, and species classes are always concrete leaf nodes. The assistant also recommends a Known Limitations section documenting that some species have IsEnriched set to false indicating stub data, hybrid species use underscore x underscore naming like Canis_latrans_x_Canis_lupus, and environmental samples may appear as species entries. The recommendations are presented as a continuation of the structured bulleted list from the previous message in the Copilot chat panel.](image-2.png)

---

## 📋 Output

The consolidated plan was saved as:

```
plan-copilotInstructionsUpdates.prompt.md
```

---

## ➡️ Next Step

Proceed to **Step 2** to execute the plan and update `copilot-instructions.md`.