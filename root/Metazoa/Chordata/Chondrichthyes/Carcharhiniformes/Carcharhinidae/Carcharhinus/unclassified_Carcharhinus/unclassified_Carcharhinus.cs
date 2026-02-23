using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus.unclassified_Carcharhinus;

/// <summary>
/// Abstract class for unclassified Carcharhinus (no rank).
/// NCBI TaxId: 2643312
/// </summary>
public abstract class unclassified_Carcharhinus : Carcharhinus, Iunclassified_Carcharhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carcharhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643312;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carcharhinus";
}
