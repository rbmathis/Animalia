using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lentipes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lentipes.unclassified_Lentipes;

/// <summary>
/// Abstract class for unclassified Lentipes (no rank).
/// NCBI TaxId: 2637775
/// </summary>
public abstract class unclassified_Lentipes : Lentipes, Iunclassified_Lentipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lentipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637775;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lentipes";
}
