using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Leptophilypnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Leptophilypnus.unclassified_Leptophilypnus;

/// <summary>
/// Abstract class for unclassified Leptophilypnus (no rank).
/// NCBI TaxId: 2626606
/// </summary>
public abstract class unclassified_Leptophilypnus : Leptophilypnus, Iunclassified_Leptophilypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptophilypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptophilypnus";
}
