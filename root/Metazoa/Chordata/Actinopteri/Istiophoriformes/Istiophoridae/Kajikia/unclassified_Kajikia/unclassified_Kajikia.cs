using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Kajikia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Kajikia.unclassified_Kajikia;

/// <summary>
/// Abstract class for unclassified Kajikia (no rank).
/// NCBI TaxId: 2735088
/// </summary>
public abstract class unclassified_Kajikia : Kajikia, Iunclassified_Kajikia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kajikia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2735088;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kajikia";
}
