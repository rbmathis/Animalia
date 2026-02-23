using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryaderces;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryaderces.unclassified_Dryaderces;

/// <summary>
/// Abstract class for unclassified Dryaderces (no rank).
/// NCBI TaxId: 2728971
/// </summary>
public abstract class unclassified_Dryaderces : Dryaderces, Iunclassified_Dryaderces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dryaderces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dryaderces";
}
