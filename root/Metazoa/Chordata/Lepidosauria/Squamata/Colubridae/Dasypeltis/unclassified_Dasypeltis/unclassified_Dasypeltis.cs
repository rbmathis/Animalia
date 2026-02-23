using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dasypeltis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dasypeltis.unclassified_Dasypeltis;

/// <summary>
/// Abstract class for unclassified Dasypeltis (no rank).
/// NCBI TaxId: 2685042
/// </summary>
public abstract class unclassified_Dasypeltis : Dasypeltis, Iunclassified_Dasypeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasypeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685042;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasypeltis";
}
