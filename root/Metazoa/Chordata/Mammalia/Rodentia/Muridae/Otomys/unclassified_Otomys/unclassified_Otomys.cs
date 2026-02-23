using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys.unclassified_Otomys;

/// <summary>
/// Abstract class for unclassified Otomys (no rank).
/// NCBI TaxId: 2635655
/// </summary>
public abstract class unclassified_Otomys : Otomys, Iunclassified_Otomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635655;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otomys";
}
