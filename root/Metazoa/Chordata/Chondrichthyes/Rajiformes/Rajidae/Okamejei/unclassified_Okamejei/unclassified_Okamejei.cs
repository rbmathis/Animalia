using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Okamejei;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Okamejei.unclassified_Okamejei;

/// <summary>
/// Abstract class for unclassified Okamejei (no rank).
/// NCBI TaxId: 2603165
/// </summary>
public abstract class unclassified_Okamejei : Okamejei, Iunclassified_Okamejei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Okamejei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2603165;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Okamejei";
}
