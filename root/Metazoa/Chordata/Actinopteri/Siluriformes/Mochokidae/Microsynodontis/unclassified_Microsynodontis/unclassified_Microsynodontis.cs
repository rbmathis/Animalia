using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Microsynodontis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Microsynodontis.unclassified_Microsynodontis;

/// <summary>
/// Abstract class for unclassified Microsynodontis (no rank).
/// NCBI TaxId: 2646126
/// </summary>
public abstract class unclassified_Microsynodontis : Microsynodontis, Iunclassified_Microsynodontis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microsynodontis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646126;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microsynodontis";
}
