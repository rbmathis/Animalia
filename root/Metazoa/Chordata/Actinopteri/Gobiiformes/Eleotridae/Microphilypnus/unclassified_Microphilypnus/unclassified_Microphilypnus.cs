using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Microphilypnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Microphilypnus.unclassified_Microphilypnus;

/// <summary>
/// Abstract class for unclassified Microphilypnus (no rank).
/// NCBI TaxId: 2648197
/// </summary>
public abstract class unclassified_Microphilypnus : Microphilypnus, Iunclassified_Microphilypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microphilypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648197;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microphilypnus";
}
