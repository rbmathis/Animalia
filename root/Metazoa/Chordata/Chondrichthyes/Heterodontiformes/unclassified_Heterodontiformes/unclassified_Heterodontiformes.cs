using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.unclassified_Heterodontiformes;

/// <summary>
/// Abstract class for unclassified Heterodontiformes (no rank).
/// NCBI TaxId: 948969
/// </summary>
public abstract class unclassified_Heterodontiformes : Heterodontiformes, Iunclassified_Heterodontiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterodontiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterodontiformes";
}
