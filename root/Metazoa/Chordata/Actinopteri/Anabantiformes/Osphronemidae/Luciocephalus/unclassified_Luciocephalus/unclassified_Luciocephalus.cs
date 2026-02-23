using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Luciocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Luciocephalus.unclassified_Luciocephalus;

/// <summary>
/// Abstract class for unclassified Luciocephalus (no rank).
/// NCBI TaxId: 2631021
/// </summary>
public abstract class unclassified_Luciocephalus : Luciocephalus, Iunclassified_Luciocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciocephalus";
}
