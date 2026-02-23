using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Coelophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Coelophrys.unclassified_Coelophrys;

/// <summary>
/// Abstract class for unclassified Coelophrys (no rank).
/// NCBI TaxId: 2626709
/// </summary>
public abstract class unclassified_Coelophrys : Coelophrys, Iunclassified_Coelophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coelophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626709;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coelophrys";
}
