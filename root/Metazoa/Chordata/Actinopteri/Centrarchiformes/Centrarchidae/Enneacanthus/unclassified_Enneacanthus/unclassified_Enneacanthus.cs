using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Enneacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Enneacanthus.unclassified_Enneacanthus;

/// <summary>
/// Abstract class for unclassified Enneacanthus (no rank).
/// NCBI TaxId: 2736025
/// </summary>
public abstract class unclassified_Enneacanthus : Enneacanthus, Iunclassified_Enneacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enneacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2736025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enneacanthus";
}
