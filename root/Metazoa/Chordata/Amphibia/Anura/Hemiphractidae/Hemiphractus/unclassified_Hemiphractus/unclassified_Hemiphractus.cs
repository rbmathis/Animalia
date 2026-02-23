using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Hemiphractus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Hemiphractus.unclassified_Hemiphractus;

/// <summary>
/// Abstract class for unclassified Hemiphractus (no rank).
/// NCBI TaxId: 2796315
/// </summary>
public abstract class unclassified_Hemiphractus : Hemiphractus, Iunclassified_Hemiphractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiphractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2796315;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiphractus";
}
