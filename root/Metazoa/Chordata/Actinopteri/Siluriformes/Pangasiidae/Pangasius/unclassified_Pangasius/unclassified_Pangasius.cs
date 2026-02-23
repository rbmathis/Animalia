using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius.unclassified_Pangasius;

/// <summary>
/// Abstract class for unclassified Pangasius (no rank).
/// NCBI TaxId: 2635346
/// </summary>
public abstract class unclassified_Pangasius : Pangasius, Iunclassified_Pangasius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pangasius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pangasius";
}
