using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.unclassified_Eleotridae;

/// <summary>
/// Abstract class for unclassified Eleotridae (no rank).
/// NCBI TaxId: 1928099
/// </summary>
public abstract class unclassified_Eleotridae : Eleotridae, Iunclassified_Eleotridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eleotridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1928099;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eleotridae";
}
