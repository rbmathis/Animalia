using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae.Harpagifer;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae.Harpagifer.unclassified_Harpagifer;

/// <summary>
/// Abstract class for unclassified Harpagifer (no rank).
/// NCBI TaxId: 2677353
/// </summary>
public abstract class unclassified_Harpagifer : Harpagifer, Iunclassified_Harpagifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harpagifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677353;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harpagifer";
}
