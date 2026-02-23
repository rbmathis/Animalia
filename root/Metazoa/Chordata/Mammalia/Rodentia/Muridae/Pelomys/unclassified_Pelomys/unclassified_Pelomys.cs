using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys.unclassified_Pelomys;

/// <summary>
/// Abstract class for unclassified Pelomys (no rank).
/// NCBI TaxId: 2642022
/// </summary>
public abstract class unclassified_Pelomys : Pelomys, Iunclassified_Pelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642022;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelomys";
}
