using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrophidion;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrophidion.unclassified_Dendrophidion;

/// <summary>
/// Abstract class for unclassified Dendrophidion (no rank).
/// NCBI TaxId: 3109752
/// </summary>
public abstract class unclassified_Dendrophidion : Dendrophidion, Iunclassified_Dendrophidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrophidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3109752;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrophidion";
}
