using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Dormitator;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Dormitator.unclassified_Dormitator;

/// <summary>
/// Abstract class for unclassified Dormitator (no rank).
/// NCBI TaxId: 3237088
/// </summary>
public abstract class unclassified_Dormitator : Dormitator, Iunclassified_Dormitator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dormitator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3237088;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dormitator";
}
