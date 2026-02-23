using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistes.unclassified_Erethistes;

/// <summary>
/// Abstract class for unclassified Erethistes (no rank).
/// NCBI TaxId: 2645547
/// </summary>
public abstract class unclassified_Erethistes : Erethistes, Iunclassified_Erethistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erethistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645547;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erethistes";
}
