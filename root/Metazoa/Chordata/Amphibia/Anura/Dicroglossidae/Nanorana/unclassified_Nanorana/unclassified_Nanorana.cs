using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana.unclassified_Nanorana;

/// <summary>
/// Abstract class for unclassified Nanorana (no rank).
/// NCBI TaxId: 2631442
/// </summary>
public abstract class unclassified_Nanorana : Nanorana, Iunclassified_Nanorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nanorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631442;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nanorana";
}
