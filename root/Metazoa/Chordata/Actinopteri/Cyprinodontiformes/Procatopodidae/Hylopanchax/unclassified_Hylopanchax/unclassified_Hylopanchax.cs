using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Hylopanchax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Hylopanchax.unclassified_Hylopanchax;

/// <summary>
/// Abstract class for unclassified Hylopanchax (no rank).
/// NCBI TaxId: 2643128
/// </summary>
public abstract class unclassified_Hylopanchax : Hylopanchax, Iunclassified_Hylopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylopanchax";
}
