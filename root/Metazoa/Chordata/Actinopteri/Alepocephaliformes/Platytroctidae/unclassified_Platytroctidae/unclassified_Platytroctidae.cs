using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.unclassified_Platytroctidae;

/// <summary>
/// Abstract class for unclassified Platytroctidae (no rank).
/// NCBI TaxId: 2726654
/// </summary>
public abstract class unclassified_Platytroctidae : Platytroctidae, Iunclassified_Platytroctidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platytroctidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726654;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platytroctidae";
}
