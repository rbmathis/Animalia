using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Mesoplodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Mesoplodon.unclassified_Mesoplodon;

/// <summary>
/// Abstract class for unclassified Mesoplodon (no rank).
/// NCBI TaxId: 2626396
/// </summary>
public abstract class unclassified_Mesoplodon : Mesoplodon, Iunclassified_Mesoplodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesoplodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626396;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesoplodon";
}
