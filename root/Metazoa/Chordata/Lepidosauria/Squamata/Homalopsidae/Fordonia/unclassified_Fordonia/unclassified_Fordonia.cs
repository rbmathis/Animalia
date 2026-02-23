using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Fordonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Fordonia.unclassified_Fordonia;

/// <summary>
/// Abstract class for unclassified Fordonia (no rank).
/// NCBI TaxId: 3476302
/// </summary>
public abstract class unclassified_Fordonia : Fordonia, Iunclassified_Fordonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fordonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3476302;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fordonia";
}
