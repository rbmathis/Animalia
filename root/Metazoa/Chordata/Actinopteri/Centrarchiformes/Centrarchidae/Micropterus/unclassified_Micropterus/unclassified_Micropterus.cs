using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Micropterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Micropterus.unclassified_Micropterus;

/// <summary>
/// Abstract class for unclassified Micropterus (no rank).
/// NCBI TaxId: 3314496
/// </summary>
public abstract class unclassified_Micropterus : Micropterus, Iunclassified_Micropterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micropterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3314496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micropterus";
}
