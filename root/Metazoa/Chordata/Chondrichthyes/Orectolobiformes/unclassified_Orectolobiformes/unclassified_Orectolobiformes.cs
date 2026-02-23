using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.unclassified_Orectolobiformes;

/// <summary>
/// Abstract class for unclassified Orectolobiformes (no rank).
/// NCBI TaxId: 727668
/// </summary>
public abstract class unclassified_Orectolobiformes : Orectolobiformes, Iunclassified_Orectolobiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orectolobiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727668;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orectolobiformes";
}
