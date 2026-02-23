using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Dendrolagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Dendrolagus.unclassified_Dendrolagus;

/// <summary>
/// Abstract class for unclassified Dendrolagus (no rank).
/// NCBI TaxId: 2640889
/// </summary>
public abstract class unclassified_Dendrolagus : Dendrolagus, Iunclassified_Dendrolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640889;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrolagus";
}
