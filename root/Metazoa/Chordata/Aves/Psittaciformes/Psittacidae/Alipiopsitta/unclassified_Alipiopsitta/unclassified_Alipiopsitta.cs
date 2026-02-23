using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alipiopsitta;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alipiopsitta.unclassified_Alipiopsitta;

/// <summary>
/// Abstract class for unclassified Alipiopsitta (no rank).
/// NCBI TaxId: 2629792
/// </summary>
public abstract class unclassified_Alipiopsitta : Alipiopsitta, Iunclassified_Alipiopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alipiopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629792;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alipiopsitta";
}
