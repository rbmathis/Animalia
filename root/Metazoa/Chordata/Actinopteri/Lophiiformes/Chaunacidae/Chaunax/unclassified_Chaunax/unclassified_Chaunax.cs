using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae.Chaunax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae.Chaunax.unclassified_Chaunax;

/// <summary>
/// Abstract class for unclassified Chaunax (no rank).
/// NCBI TaxId: 2637992
/// </summary>
public abstract class unclassified_Chaunax : Chaunax, Iunclassified_Chaunax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaunax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637992;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaunax";
}
