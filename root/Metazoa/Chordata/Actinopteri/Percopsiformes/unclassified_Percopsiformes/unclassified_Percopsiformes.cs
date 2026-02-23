using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.unclassified_Percopsiformes;

/// <summary>
/// Abstract class for unclassified Percopsiformes (no rank).
/// NCBI TaxId: 915502
/// </summary>
public abstract class unclassified_Percopsiformes : Percopsiformes, Iunclassified_Percopsiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Percopsiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 915502;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Percopsiformes";
}
