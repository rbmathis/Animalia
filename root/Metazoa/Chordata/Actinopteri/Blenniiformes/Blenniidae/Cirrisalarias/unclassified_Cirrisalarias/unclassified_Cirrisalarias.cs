using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirrisalarias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirrisalarias.unclassified_Cirrisalarias;

/// <summary>
/// Abstract class for unclassified Cirrisalarias (no rank).
/// NCBI TaxId: 3397021
/// </summary>
public abstract class unclassified_Cirrisalarias : Cirrisalarias, Iunclassified_Cirrisalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrisalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3397021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrisalarias";
}
