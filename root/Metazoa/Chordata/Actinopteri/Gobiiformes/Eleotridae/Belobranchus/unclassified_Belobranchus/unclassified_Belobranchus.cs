using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Belobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Belobranchus.unclassified_Belobranchus;

/// <summary>
/// Abstract class for unclassified Belobranchus (no rank).
/// NCBI TaxId: 2650957
/// </summary>
public abstract class unclassified_Belobranchus : Belobranchus, Iunclassified_Belobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Belobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650957;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Belobranchus";
}
