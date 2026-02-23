using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathycongrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathycongrus.unclassified_Bathycongrus;

/// <summary>
/// Abstract class for unclassified Bathycongrus (no rank).
/// NCBI TaxId: 2726526
/// </summary>
public abstract class unclassified_Bathycongrus : Bathycongrus, Iunclassified_Bathycongrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathycongrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726526;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathycongrus";
}
