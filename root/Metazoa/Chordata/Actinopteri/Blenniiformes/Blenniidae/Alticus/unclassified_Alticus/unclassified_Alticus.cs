using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Alticus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Alticus.unclassified_Alticus;

/// <summary>
/// Abstract class for unclassified Alticus (no rank).
/// NCBI TaxId: 2621396
/// </summary>
public abstract class unclassified_Alticus : Alticus, Iunclassified_Alticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621396;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alticus";
}
