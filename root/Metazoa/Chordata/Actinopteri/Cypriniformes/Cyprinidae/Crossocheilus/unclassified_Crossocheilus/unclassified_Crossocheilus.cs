using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Crossocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Crossocheilus.unclassified_Crossocheilus;

/// <summary>
/// Abstract class for unclassified Crossocheilus (no rank).
/// NCBI TaxId: 2628515
/// </summary>
public abstract class unclassified_Crossocheilus : Crossocheilus, Iunclassified_Crossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628515;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crossocheilus";
}
