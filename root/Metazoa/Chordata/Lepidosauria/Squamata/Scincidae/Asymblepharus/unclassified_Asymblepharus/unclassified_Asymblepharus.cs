using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Asymblepharus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Asymblepharus.unclassified_Asymblepharus;

/// <summary>
/// Abstract class for unclassified Asymblepharus (no rank).
/// NCBI TaxId: 2795866
/// </summary>
public abstract class unclassified_Asymblepharus : Asymblepharus, Iunclassified_Asymblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asymblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795866;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asymblepharus";
}
