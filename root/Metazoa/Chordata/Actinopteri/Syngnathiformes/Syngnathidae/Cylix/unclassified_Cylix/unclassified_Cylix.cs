using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Cylix;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Cylix.unclassified_Cylix;

/// <summary>
/// Abstract class for unclassified Cylix (no rank).
/// NCBI TaxId: 2986466
/// </summary>
public abstract class unclassified_Cylix : Cylix, Iunclassified_Cylix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cylix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986466;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cylix";
}
