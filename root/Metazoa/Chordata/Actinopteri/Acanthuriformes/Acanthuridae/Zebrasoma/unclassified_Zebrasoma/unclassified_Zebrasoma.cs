using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Zebrasoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Zebrasoma.unclassified_Zebrasoma;

/// <summary>
/// Abstract class for unclassified Zebrasoma (no rank).
/// NCBI TaxId: 2646241
/// </summary>
public abstract class unclassified_Zebrasoma : Zebrasoma, Iunclassified_Zebrasoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zebrasoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zebrasoma";
}
