using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Parakneria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Parakneria.unclassified_Parakneria;

/// <summary>
/// Abstract class for unclassified Parakneria (no rank).
/// NCBI TaxId: 2633206
/// </summary>
public abstract class unclassified_Parakneria : Parakneria, Iunclassified_Parakneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parakneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633206;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parakneria";
}
