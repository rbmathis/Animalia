using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.unclassified_Gobiiformes;

/// <summary>
/// Abstract class for unclassified Gobiiformes (no rank).
/// NCBI TaxId: 1703792
/// </summary>
public abstract class unclassified_Gobiiformes : Gobiiformes, Iunclassified_Gobiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1703792;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiiformes";
}
