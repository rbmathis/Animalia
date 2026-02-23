using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathytroctes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathytroctes.unclassified_Bathytroctes;

/// <summary>
/// Abstract class for unclassified Bathytroctes (no rank).
/// NCBI TaxId: 3415242
/// </summary>
public abstract class unclassified_Bathytroctes : Bathytroctes, Iunclassified_Bathytroctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathytroctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3415242;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathytroctes";
}
