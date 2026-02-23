using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathus.unclassified_Syngnathus;

/// <summary>
/// Abstract class for unclassified Syngnathus (no rank).
/// NCBI TaxId: 2619438
/// </summary>
public abstract class unclassified_Syngnathus : Syngnathus, Iunclassified_Syngnathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syngnathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syngnathus";
}
