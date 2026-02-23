using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Pristiophoriformes;

/// <summary>
/// Abstract class for unclassified Pristiophoriformes (no rank).
/// NCBI TaxId: 732570
/// </summary>
public abstract class unclassified_Pristiophoriformes : Chondrichthyes, Iunclassified_Pristiophoriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristiophoriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristiophoriformes";
}
