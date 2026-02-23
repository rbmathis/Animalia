using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys.unclassified_Dactylomys;

/// <summary>
/// Abstract class for unclassified Dactylomys (no rank).
/// NCBI TaxId: 3115252
/// </summary>
public abstract class unclassified_Dactylomys : Dactylomys, Iunclassified_Dactylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dactylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115252;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dactylomys";
}
