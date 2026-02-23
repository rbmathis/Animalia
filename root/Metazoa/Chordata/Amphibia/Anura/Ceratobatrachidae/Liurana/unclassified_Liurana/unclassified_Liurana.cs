using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Liurana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Liurana.unclassified_Liurana;

/// <summary>
/// Abstract class for unclassified Liurana (no rank).
/// NCBI TaxId: 2622163
/// </summary>
public abstract class unclassified_Liurana : Liurana, Iunclassified_Liurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622163;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liurana";
}
