using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.unclassified_Squaliformes;

/// <summary>
/// Abstract class for unclassified Squaliformes (no rank).
/// NCBI TaxId: 727670
/// </summary>
public abstract class unclassified_Squaliformes : Squaliformes, Iunclassified_Squaliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squaliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squaliformes";
}
