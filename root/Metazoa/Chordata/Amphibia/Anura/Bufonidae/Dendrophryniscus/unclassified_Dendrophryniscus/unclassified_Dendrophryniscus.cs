using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Dendrophryniscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Dendrophryniscus.unclassified_Dendrophryniscus;

/// <summary>
/// Abstract class for unclassified Dendrophryniscus (no rank).
/// NCBI TaxId: 2619227
/// </summary>
public abstract class unclassified_Dendrophryniscus : Dendrophryniscus, Iunclassified_Dendrophryniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrophryniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619227;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrophryniscus";
}
