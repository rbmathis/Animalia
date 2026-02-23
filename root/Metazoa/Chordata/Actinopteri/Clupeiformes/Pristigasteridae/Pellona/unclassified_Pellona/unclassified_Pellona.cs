using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Pellona;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Pellona.unclassified_Pellona;

/// <summary>
/// Abstract class for unclassified Pellona (no rank).
/// NCBI TaxId: 3062189
/// </summary>
public abstract class unclassified_Pellona : Pellona, Iunclassified_Pellona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pellona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3062189;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pellona";
}
