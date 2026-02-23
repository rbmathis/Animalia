using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Heremites;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Heremites.unclassified_Heremites;

/// <summary>
/// Abstract class for unclassified Heremites (no rank).
/// NCBI TaxId: 2624854
/// </summary>
public abstract class unclassified_Heremites : Heremites, Iunclassified_Heremites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heremites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624854;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heremites";
}
