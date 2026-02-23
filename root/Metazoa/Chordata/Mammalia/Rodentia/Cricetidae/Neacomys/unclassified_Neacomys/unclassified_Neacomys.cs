using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys.unclassified_Neacomys;

/// <summary>
/// Abstract class for unclassified Neacomys (no rank).
/// NCBI TaxId: 2646213
/// </summary>
public abstract class unclassified_Neacomys : Neacomys, Iunclassified_Neacomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neacomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646213;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neacomys";
}
