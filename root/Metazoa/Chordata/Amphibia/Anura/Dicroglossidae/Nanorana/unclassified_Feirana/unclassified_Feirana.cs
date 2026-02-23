using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana.unclassified_Feirana;

/// <summary>
/// Abstract class for unclassified Feirana (no rank).
/// NCBI TaxId: 2937431
/// </summary>
public abstract class unclassified_Feirana : Nanorana, Iunclassified_Feirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Feirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2937431;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Feirana";
}
