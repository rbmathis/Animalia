using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys.unclassified_Calomys;

/// <summary>
/// Abstract class for unclassified Calomys (no rank).
/// NCBI TaxId: 2637197
/// </summary>
public abstract class unclassified_Calomys : Calomys, Iunclassified_Calomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637197;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calomys";
}
