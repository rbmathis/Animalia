using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Acontias;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Acontias.unclassified_Acontias;

/// <summary>
/// Abstract class for unclassified Acontias (no rank).
/// NCBI TaxId: 2631355
/// </summary>
public abstract class unclassified_Acontias : Acontias, Iunclassified_Acontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631355;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acontias";
}
