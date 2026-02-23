using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Maulisia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Maulisia.unclassified_Maulisia;

/// <summary>
/// Abstract class for unclassified Maulisia (no rank).
/// NCBI TaxId: 2631451
/// </summary>
public abstract class unclassified_Maulisia : Maulisia, Iunclassified_Maulisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maulisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maulisia";
}
