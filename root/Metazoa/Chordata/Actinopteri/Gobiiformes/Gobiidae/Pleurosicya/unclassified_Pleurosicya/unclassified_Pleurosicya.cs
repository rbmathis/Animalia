using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pleurosicya;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pleurosicya.unclassified_Pleurosicya;

/// <summary>
/// Abstract class for unclassified Pleurosicya (no rank).
/// NCBI TaxId: 2623366
/// </summary>
public abstract class unclassified_Pleurosicya : Pleurosicya, Iunclassified_Pleurosicya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pleurosicya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pleurosicya";
}
