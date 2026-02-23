using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Marcusenius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Marcusenius.unclassified_Marcusenius;

/// <summary>
/// Abstract class for unclassified Marcusenius (no rank).
/// NCBI TaxId: 2602740
/// </summary>
public abstract class unclassified_Marcusenius : Marcusenius, Iunclassified_Marcusenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Marcusenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602740;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Marcusenius";
}
