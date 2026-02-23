using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Doryrhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Doryrhamphus.unclassified_Doryrhamphus;

/// <summary>
/// Abstract class for unclassified Doryrhamphus (no rank).
/// NCBI TaxId: 2619208
/// </summary>
public abstract class unclassified_Doryrhamphus : Doryrhamphus, Iunclassified_Doryrhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doryrhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619208;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doryrhamphus";
}
