using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.unclassified_Muraenidae;

/// <summary>
/// Abstract class for unclassified Muraenidae (no rank).
/// NCBI TaxId: 1910858
/// </summary>
public abstract class unclassified_Muraenidae : Muraenidae, Iunclassified_Muraenidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muraenidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1910858;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muraenidae";
}
