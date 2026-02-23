using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys.unclassified_Uromys;

/// <summary>
/// Abstract class for unclassified Uromys (no rank).
/// NCBI TaxId: 3148845
/// </summary>
public abstract class unclassified_Uromys : Uromys, Iunclassified_Uromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uromys";
}
