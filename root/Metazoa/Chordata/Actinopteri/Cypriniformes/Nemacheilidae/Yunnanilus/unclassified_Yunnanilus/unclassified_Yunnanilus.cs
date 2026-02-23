using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Yunnanilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Yunnanilus.unclassified_Yunnanilus;

/// <summary>
/// Abstract class for unclassified Yunnanilus (no rank).
/// NCBI TaxId: 2632628
/// </summary>
public abstract class unclassified_Yunnanilus : Yunnanilus, Iunclassified_Yunnanilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yunnanilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632628;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yunnanilus";
}
