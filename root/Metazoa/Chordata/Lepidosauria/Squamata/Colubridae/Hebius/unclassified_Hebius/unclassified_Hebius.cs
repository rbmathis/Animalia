using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hebius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hebius.unclassified_Hebius;

/// <summary>
/// Abstract class for unclassified Hebius (no rank).
/// NCBI TaxId: 2648452
/// </summary>
public abstract class unclassified_Hebius : Hebius, Iunclassified_Hebius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hebius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648452;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hebius";
}
