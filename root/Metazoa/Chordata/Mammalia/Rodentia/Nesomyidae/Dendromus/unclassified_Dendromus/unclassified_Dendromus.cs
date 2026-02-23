using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Dendromus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Dendromus.unclassified_Dendromus;

/// <summary>
/// Abstract class for unclassified Dendromus (no rank).
/// NCBI TaxId: 2619740
/// </summary>
public abstract class unclassified_Dendromus : Dendromus, Iunclassified_Dendromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619740;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendromus";
}
