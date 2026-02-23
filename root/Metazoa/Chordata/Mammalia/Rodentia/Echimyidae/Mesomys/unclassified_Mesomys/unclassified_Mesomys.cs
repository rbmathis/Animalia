using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Mesomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Mesomys.unclassified_Mesomys;

/// <summary>
/// Abstract class for unclassified Mesomys (no rank).
/// NCBI TaxId: 2649027
/// </summary>
public abstract class unclassified_Mesomys : Mesomys, Iunclassified_Mesomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649027;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesomys";
}
