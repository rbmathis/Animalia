using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys.unclassified_Parotomys;

/// <summary>
/// Abstract class for unclassified Parotomys (no rank).
/// NCBI TaxId: 2644614
/// </summary>
public abstract class unclassified_Parotomys : Parotomys, Iunclassified_Parotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644614;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parotomys";
}
