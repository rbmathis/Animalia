using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys.unclassified_Acomys;

/// <summary>
/// Abstract class for unclassified Acomys (no rank).
/// NCBI TaxId: 2642879
/// </summary>
public abstract class unclassified_Acomys : Acomys, Iunclassified_Acomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642879;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acomys";
}
