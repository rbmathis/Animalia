using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys.unclassified_Cryptomys;

/// <summary>
/// Abstract class for unclassified Cryptomys (no rank).
/// NCBI TaxId: 2639977
/// </summary>
public abstract class unclassified_Cryptomys : Cryptomys, Iunclassified_Cryptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639977;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptomys";
}
