using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae.Jenynsia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae.Jenynsia.unclassified_Jenynsia;

/// <summary>
/// Abstract class for unclassified Jenynsia (no rank).
/// NCBI TaxId: 2624507
/// </summary>
public abstract class unclassified_Jenynsia : Jenynsia, Iunclassified_Jenynsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jenynsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624507;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jenynsia";
}
