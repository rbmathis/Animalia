using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Idiotropiscis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Idiotropiscis.unclassified_Idiotropiscis;

/// <summary>
/// Abstract class for unclassified Idiotropiscis (no rank).
/// NCBI TaxId: 2629717
/// </summary>
public abstract class unclassified_Idiotropiscis : Idiotropiscis, Iunclassified_Idiotropiscis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Idiotropiscis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629717;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Idiotropiscis";
}
