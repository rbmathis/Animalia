using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Raiamas;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Raiamas.unclassified_Raiamas;

/// <summary>
/// Abstract class for unclassified Raiamas (no rank).
/// NCBI TaxId: 2630735
/// </summary>
public abstract class unclassified_Raiamas : Raiamas, Iunclassified_Raiamas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Raiamas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630735;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Raiamas";
}
