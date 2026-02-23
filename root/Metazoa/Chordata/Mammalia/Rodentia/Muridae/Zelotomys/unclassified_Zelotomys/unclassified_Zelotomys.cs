using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zelotomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zelotomys.unclassified_Zelotomys;

/// <summary>
/// Abstract class for unclassified Zelotomys (no rank).
/// NCBI TaxId: 2819606
/// </summary>
public abstract class unclassified_Zelotomys : Zelotomys, Iunclassified_Zelotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zelotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zelotomys";
}
