using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Synodontis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Synodontis.unclassified_Synodontis;

/// <summary>
/// Abstract class for unclassified Synodontis (no rank).
/// NCBI TaxId: 2627379
/// </summary>
public abstract class unclassified_Synodontis : Synodontis, Iunclassified_Synodontis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synodontis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627379;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synodontis";
}
