using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nephelomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nephelomys.unclassified_Nephelomys;

/// <summary>
/// Abstract class for unclassified Nephelomys (no rank).
/// NCBI TaxId: 2636216
/// </summary>
public abstract class unclassified_Nephelomys : Nephelomys, Iunclassified_Nephelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nephelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636216;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nephelomys";
}
