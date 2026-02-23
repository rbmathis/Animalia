using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Oreophrynella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Oreophrynella.unclassified_Oreophrynella;

/// <summary>
/// Abstract class for unclassified Oreophrynella (no rank).
/// NCBI TaxId: 2633636
/// </summary>
public abstract class unclassified_Oreophrynella : Oreophrynella, Iunclassified_Oreophrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreophrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreophrynella";
}
