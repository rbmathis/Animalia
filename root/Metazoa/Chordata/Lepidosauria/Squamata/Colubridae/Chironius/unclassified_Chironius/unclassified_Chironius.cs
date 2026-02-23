using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Chironius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Chironius.unclassified_Chironius;

/// <summary>
/// Abstract class for unclassified Chironius (no rank).
/// NCBI TaxId: 2631764
/// </summary>
public abstract class unclassified_Chironius : Chironius, Iunclassified_Chironius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chironius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chironius";
}
