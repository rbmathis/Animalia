using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Potamorrhaphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Potamorrhaphis.unclassified_Potamorrhaphis;

/// <summary>
/// Abstract class for unclassified Potamorrhaphis (no rank).
/// NCBI TaxId: 3101894
/// </summary>
public abstract class unclassified_Potamorrhaphis : Potamorrhaphis, Iunclassified_Potamorrhaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Potamorrhaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Potamorrhaphis";
}
