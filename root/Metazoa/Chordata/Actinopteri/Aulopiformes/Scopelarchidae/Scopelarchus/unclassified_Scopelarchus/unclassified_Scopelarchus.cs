using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Scopelarchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Scopelarchus.unclassified_Scopelarchus;

/// <summary>
/// Abstract class for unclassified Scopelarchus (no rank).
/// NCBI TaxId: 2641081
/// </summary>
public abstract class unclassified_Scopelarchus : Scopelarchus, Iunclassified_Scopelarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scopelarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641081;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scopelarchus";
}
