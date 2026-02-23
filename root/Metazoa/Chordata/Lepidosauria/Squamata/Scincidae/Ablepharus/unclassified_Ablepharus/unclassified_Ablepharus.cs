using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ablepharus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ablepharus.unclassified_Ablepharus;

/// <summary>
/// Abstract class for unclassified Ablepharus (no rank).
/// NCBI TaxId: 3233352
/// </summary>
public abstract class unclassified_Ablepharus : Ablepharus, Iunclassified_Ablepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3233352;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ablepharus";
}
