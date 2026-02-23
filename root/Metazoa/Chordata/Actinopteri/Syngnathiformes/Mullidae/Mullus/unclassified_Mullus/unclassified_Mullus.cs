using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mullus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mullus.unclassified_Mullus;

/// <summary>
/// Abstract class for unclassified Mullus (no rank).
/// NCBI TaxId: 2645928
/// </summary>
public abstract class unclassified_Mullus : Mullus, Iunclassified_Mullus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mullus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mullus";
}
