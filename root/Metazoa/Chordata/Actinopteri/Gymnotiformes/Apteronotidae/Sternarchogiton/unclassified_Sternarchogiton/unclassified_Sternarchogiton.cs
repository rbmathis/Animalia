using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchogiton;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchogiton.unclassified_Sternarchogiton;

/// <summary>
/// Abstract class for unclassified Sternarchogiton (no rank).
/// NCBI TaxId: 2648244
/// </summary>
public abstract class unclassified_Sternarchogiton : Sternarchogiton, Iunclassified_Sternarchogiton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternarchogiton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648244;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternarchogiton";
}
