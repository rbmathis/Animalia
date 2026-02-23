using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.unclassified_Myxiniformes;

/// <summary>
/// Abstract class for unclassified Myxiniformes (no rank).
/// NCBI TaxId: 727487
/// </summary>
public abstract class unclassified_Myxiniformes : Myxiniformes, Iunclassified_Myxiniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myxiniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727487;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myxiniformes";
}
