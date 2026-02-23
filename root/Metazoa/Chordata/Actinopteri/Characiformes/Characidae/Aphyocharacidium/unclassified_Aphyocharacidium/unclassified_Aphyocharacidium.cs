using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharacidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharacidium.unclassified_Aphyocharacidium;

/// <summary>
/// Abstract class for unclassified Aphyocharacidium (no rank).
/// NCBI TaxId: 2608175
/// </summary>
public abstract class unclassified_Aphyocharacidium : Aphyocharacidium, Iunclassified_Aphyocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphyocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608175;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphyocharacidium";
}
