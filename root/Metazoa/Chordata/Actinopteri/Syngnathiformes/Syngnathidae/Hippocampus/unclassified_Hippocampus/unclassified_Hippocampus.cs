using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hippocampus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hippocampus.unclassified_Hippocampus;

/// <summary>
/// Abstract class for unclassified Hippocampus (no rank).
/// NCBI TaxId: 2619675
/// </summary>
public abstract class unclassified_Hippocampus : Hippocampus, Iunclassified_Hippocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hippocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619675;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hippocampus";
}
