using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Imparfinis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Imparfinis.unclassified_Imparfinis;

/// <summary>
/// Abstract class for unclassified Imparfinis (no rank).
/// NCBI TaxId: 2642399
/// </summary>
public abstract class unclassified_Imparfinis : Imparfinis, Iunclassified_Imparfinis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Imparfinis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642399;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Imparfinis";
}
