using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Leucostethus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Leucostethus.unclassified_Leucostethus;

/// <summary>
/// Abstract class for unclassified Leucostethus (no rank).
/// NCBI TaxId: 2994278
/// </summary>
public abstract class unclassified_Leucostethus : Leucostethus, Iunclassified_Leucostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leucostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2994278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leucostethus";
}
