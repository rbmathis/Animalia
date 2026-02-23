using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lampropholis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lampropholis.unclassified_Lampropholis;

/// <summary>
/// Abstract class for unclassified Lampropholis (no rank).
/// NCBI TaxId: 3411762
/// </summary>
public abstract class unclassified_Lampropholis : Lampropholis, Iunclassified_Lampropholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampropholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411762;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampropholis";
}
