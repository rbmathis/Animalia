using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ahaetulla;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ahaetulla.unclassified_Ahaetulla;

/// <summary>
/// Abstract class for unclassified Ahaetulla (no rank).
/// NCBI TaxId: 2729181
/// </summary>
public abstract class unclassified_Ahaetulla : Ahaetulla, Iunclassified_Ahaetulla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ahaetulla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2729181;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ahaetulla";
}
