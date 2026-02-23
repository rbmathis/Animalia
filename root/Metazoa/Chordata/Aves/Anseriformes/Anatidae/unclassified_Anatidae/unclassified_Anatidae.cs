using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.unclassified_Anatidae;

/// <summary>
/// Abstract class for unclassified Anatidae (no rank).
/// NCBI TaxId: 2068732
/// </summary>
public abstract class unclassified_Anatidae : Anatidae, Iunclassified_Anatidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anatidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2068732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anatidae";
}
