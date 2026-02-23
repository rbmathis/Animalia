using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae.Kraemeria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae.Kraemeria.unclassified_Kraemeria;

/// <summary>
/// Abstract class for unclassified Kraemeria (no rank).
/// NCBI TaxId: 3439077
/// </summary>
public abstract class unclassified_Kraemeria : Kraemeria, Iunclassified_Kraemeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kraemeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3439077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kraemeria";
}
