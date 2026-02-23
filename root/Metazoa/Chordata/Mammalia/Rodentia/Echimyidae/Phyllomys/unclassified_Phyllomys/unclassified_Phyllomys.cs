using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys.unclassified_Phyllomys;

/// <summary>
/// Abstract class for unclassified Phyllomys (no rank).
/// NCBI TaxId: 2641919
/// </summary>
public abstract class unclassified_Phyllomys : Phyllomys, Iunclassified_Phyllomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641919;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllomys";
}
