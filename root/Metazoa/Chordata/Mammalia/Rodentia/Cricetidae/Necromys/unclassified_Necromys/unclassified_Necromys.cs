using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys.unclassified_Necromys;

/// <summary>
/// Abstract class for unclassified Necromys (no rank).
/// NCBI TaxId: 2618621
/// </summary>
public abstract class unclassified_Necromys : Necromys, Iunclassified_Necromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Necromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618621;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Necromys";
}
