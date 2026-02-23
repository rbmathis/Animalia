using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Malpolon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Malpolon.unclassified_Malpolon;

/// <summary>
/// Abstract class for unclassified Malpolon (no rank).
/// NCBI TaxId: 2974577
/// </summary>
public abstract class unclassified_Malpolon : Malpolon, Iunclassified_Malpolon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Malpolon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2974577;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Malpolon";
}
