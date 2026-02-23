using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.unclassified_Syngnathidae;

/// <summary>
/// Abstract class for unclassified Syngnathidae (no rank).
/// NCBI TaxId: 1182124
/// </summary>
public abstract class unclassified_Syngnathidae : Syngnathidae, Iunclassified_Syngnathidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syngnathidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syngnathidae";
}
