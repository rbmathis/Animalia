using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocyclocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocyclocheilus.unclassified_Sinocyclocheilus;

/// <summary>
/// Abstract class for unclassified Sinocyclocheilus (no rank).
/// NCBI TaxId: 2635240
/// </summary>
public abstract class unclassified_Sinocyclocheilus : Sinocyclocheilus, Iunclassified_Sinocyclocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinocyclocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635240;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinocyclocheilus";
}
