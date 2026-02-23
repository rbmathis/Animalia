using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hepsetidae.Hepsetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hepsetidae.Hepsetus.unclassified_Hepsetus;

/// <summary>
/// Abstract class for unclassified Hepsetus (no rank).
/// NCBI TaxId: 2644478
/// </summary>
public abstract class unclassified_Hepsetus : Hepsetus, Iunclassified_Hepsetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hepsetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644478;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hepsetus";
}
