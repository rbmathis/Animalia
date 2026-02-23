using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.unclassified_Typhlopidae;

/// <summary>
/// Abstract class for unclassified Typhlopidae (no rank).
/// NCBI TaxId: 1297051
/// </summary>
public abstract class unclassified_Typhlopidae : Typhlopidae, Iunclassified_Typhlopidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlopidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1297051;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlopidae";
}
