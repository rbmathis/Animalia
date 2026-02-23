using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.unclassified_Dendrobatidae;

/// <summary>
/// Abstract class for unclassified Dendrobatidae (no rank).
/// NCBI TaxId: 3117550
/// </summary>
public abstract class unclassified_Dendrobatidae : Dendrobatidae, Iunclassified_Dendrobatidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrobatidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3117550;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrobatidae";
}
