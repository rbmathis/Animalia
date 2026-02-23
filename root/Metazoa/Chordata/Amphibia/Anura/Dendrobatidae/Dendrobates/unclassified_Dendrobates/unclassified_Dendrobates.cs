using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates.unclassified_Dendrobates;

/// <summary>
/// Abstract class for unclassified Dendrobates (no rank).
/// NCBI TaxId: 2618040
/// </summary>
public abstract class unclassified_Dendrobates : Dendrobates, Iunclassified_Dendrobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618040;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrobates";
}
