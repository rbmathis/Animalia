using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Microcaecilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Microcaecilia.unclassified_Microcaecilia;

/// <summary>
/// Abstract class for unclassified Microcaecilia (no rank).
/// NCBI TaxId: 2638104
/// </summary>
public abstract class unclassified_Microcaecilia : Microcaecilia, Iunclassified_Microcaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcaecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638104;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcaecilia";
}
