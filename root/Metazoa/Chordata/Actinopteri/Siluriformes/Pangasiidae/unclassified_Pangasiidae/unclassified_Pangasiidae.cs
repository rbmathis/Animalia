using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.unclassified_Pangasiidae;

/// <summary>
/// Abstract class for unclassified Pangasiidae (no rank).
/// NCBI TaxId: 1977494
/// </summary>
public abstract class unclassified_Pangasiidae : Pangasiidae, Iunclassified_Pangasiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pangasiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1977494;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pangasiidae";
}
