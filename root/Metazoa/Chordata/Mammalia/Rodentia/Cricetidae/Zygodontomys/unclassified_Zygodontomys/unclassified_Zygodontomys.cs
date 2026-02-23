using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Zygodontomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Zygodontomys.unclassified_Zygodontomys;

/// <summary>
/// Abstract class for unclassified Zygodontomys (no rank).
/// NCBI TaxId: 2634149
/// </summary>
public abstract class unclassified_Zygodontomys : Zygodontomys, Iunclassified_Zygodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zygodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zygodontomys";
}
