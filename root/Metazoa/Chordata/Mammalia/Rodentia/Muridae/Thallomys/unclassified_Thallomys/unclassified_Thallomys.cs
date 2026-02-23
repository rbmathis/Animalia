using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys.unclassified_Thallomys;

/// <summary>
/// Abstract class for unclassified Thallomys (no rank).
/// NCBI TaxId: 2685323
/// </summary>
public abstract class unclassified_Thallomys : Thallomys, Iunclassified_Thallomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thallomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685323;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thallomys";
}
