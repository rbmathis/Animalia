using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys.unclassified_Lophuromys;

/// <summary>
/// Abstract class for unclassified Lophuromys (no rank).
/// NCBI TaxId: 2644584
/// </summary>
public abstract class unclassified_Lophuromys : Lophuromys, Iunclassified_Lophuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lophuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644584;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lophuromys";
}
