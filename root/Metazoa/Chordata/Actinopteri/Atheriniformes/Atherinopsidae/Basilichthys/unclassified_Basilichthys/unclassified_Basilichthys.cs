using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Basilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Basilichthys.unclassified_Basilichthys;

/// <summary>
/// Abstract class for unclassified Basilichthys (no rank).
/// NCBI TaxId: 2621458
/// </summary>
public abstract class unclassified_Basilichthys : Basilichthys, Iunclassified_Basilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Basilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621458;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Basilichthys";
}
