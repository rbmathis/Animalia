using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sanguirana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sanguirana.unclassified_Sanguirana;

/// <summary>
/// Abstract class for unclassified Sanguirana (no rank).
/// NCBI TaxId: 2621770
/// </summary>
public abstract class unclassified_Sanguirana : Sanguirana, Iunclassified_Sanguirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sanguirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621770;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sanguirana";
}
