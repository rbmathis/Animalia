using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Xenomystax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Xenomystax.unclassified_Xenomystax;

/// <summary>
/// Abstract class for unclassified Xenomystax (no rank).
/// NCBI TaxId: 3021975
/// </summary>
public abstract class unclassified_Xenomystax : Xenomystax, Iunclassified_Xenomystax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenomystax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3021975;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenomystax";
}
