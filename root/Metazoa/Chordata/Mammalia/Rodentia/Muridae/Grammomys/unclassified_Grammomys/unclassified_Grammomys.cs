using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys.unclassified_Grammomys;

/// <summary>
/// Abstract class for unclassified Grammomys (no rank).
/// NCBI TaxId: 2636249
/// </summary>
public abstract class unclassified_Grammomys : Grammomys, Iunclassified_Grammomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Grammomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636249;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Grammomys";
}
