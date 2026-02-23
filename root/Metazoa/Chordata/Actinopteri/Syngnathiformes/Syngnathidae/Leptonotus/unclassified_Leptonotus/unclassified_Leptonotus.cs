using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Leptonotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Leptonotus.unclassified_Leptonotus;

/// <summary>
/// Abstract class for unclassified Leptonotus (no rank).
/// NCBI TaxId: 2766941
/// </summary>
public abstract class unclassified_Leptonotus : Leptonotus, Iunclassified_Leptonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766941;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptonotus";
}
