using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko.unclassified_Gekko;

/// <summary>
/// Abstract class for unclassified Gekko (no rank).
/// NCBI TaxId: 2649178
/// </summary>
public abstract class unclassified_Gekko : Gekko, Iunclassified_Gekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649178;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gekko";
}
