using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae.Gyrinocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae.Gyrinocheilus.unclassified_Gyrinocheilus;

/// <summary>
/// Abstract class for unclassified Gyrinocheilus (no rank).
/// NCBI TaxId: 2624534
/// </summary>
public abstract class unclassified_Gyrinocheilus : Gyrinocheilus, Iunclassified_Gyrinocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gyrinocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624534;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gyrinocheilus";
}
