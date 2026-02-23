using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae.Neblinaphryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae.Neblinaphryne.unclassified_Neblinaphryne;

/// <summary>
/// Abstract class for unclassified Neblinaphryne (no rank).
/// NCBI TaxId: 3149204
/// </summary>
public abstract class unclassified_Neblinaphryne : Neblinaphryne, Iunclassified_Neblinaphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neblinaphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3149204;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neblinaphryne";
}
