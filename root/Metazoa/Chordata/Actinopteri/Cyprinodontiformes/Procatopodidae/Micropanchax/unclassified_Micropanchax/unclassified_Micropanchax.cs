using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Micropanchax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Micropanchax.unclassified_Micropanchax;

/// <summary>
/// Abstract class for unclassified Micropanchax (no rank).
/// NCBI TaxId: 2637092
/// </summary>
public abstract class unclassified_Micropanchax : Micropanchax, Iunclassified_Micropanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micropanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micropanchax";
}
