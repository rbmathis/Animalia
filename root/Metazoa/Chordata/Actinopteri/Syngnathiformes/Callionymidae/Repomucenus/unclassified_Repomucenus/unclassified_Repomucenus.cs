using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Repomucenus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Repomucenus.unclassified_Repomucenus;

/// <summary>
/// Abstract class for unclassified Repomucenus (no rank).
/// NCBI TaxId: 2629078
/// </summary>
public abstract class unclassified_Repomucenus : Repomucenus, Iunclassified_Repomucenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Repomucenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629078;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Repomucenus";
}
