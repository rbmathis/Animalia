using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhamphus.unclassified_Sternarchorhamphus;

/// <summary>
/// Abstract class for unclassified Sternarchorhamphus (no rank).
/// NCBI TaxId: 2638169
/// </summary>
public abstract class unclassified_Sternarchorhamphus : Sternarchorhamphus, Iunclassified_Sternarchorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternarchorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638169;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternarchorhamphus";
}
