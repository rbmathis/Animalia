using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Melomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Melomys.unclassified_Melomys;

/// <summary>
/// Abstract class for unclassified Melomys (no rank).
/// NCBI TaxId: 2621008
/// </summary>
public abstract class unclassified_Melomys : Melomys, Iunclassified_Melomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621008;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melomys";
}
