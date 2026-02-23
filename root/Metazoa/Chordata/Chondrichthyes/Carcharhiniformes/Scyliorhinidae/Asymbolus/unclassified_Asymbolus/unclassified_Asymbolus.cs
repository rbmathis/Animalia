using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Asymbolus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Asymbolus.unclassified_Asymbolus;

/// <summary>
/// Abstract class for unclassified Asymbolus (no rank).
/// NCBI TaxId: 2637670
/// </summary>
public abstract class unclassified_Asymbolus : Asymbolus, Iunclassified_Asymbolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asymbolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asymbolus";
}
