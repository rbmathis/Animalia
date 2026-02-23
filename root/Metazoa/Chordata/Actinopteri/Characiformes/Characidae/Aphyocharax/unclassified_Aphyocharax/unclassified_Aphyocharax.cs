using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharax.unclassified_Aphyocharax;

/// <summary>
/// Abstract class for unclassified Aphyocharax (no rank).
/// NCBI TaxId: 2647590
/// </summary>
public abstract class unclassified_Aphyocharax : Aphyocharax, Iunclassified_Aphyocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphyocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647590;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphyocharax";
}
