using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.unclassified_Lamniformes;

/// <summary>
/// Abstract class for unclassified Lamniformes (no rank).
/// NCBI TaxId: 732568
/// </summary>
public abstract class unclassified_Lamniformes : Lamniformes, Iunclassified_Lamniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lamniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732568;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lamniformes";
}
