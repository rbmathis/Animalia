using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Arothron;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Arothron.unclassified_Arothron;

/// <summary>
/// Abstract class for unclassified Arothron (no rank).
/// NCBI TaxId: 2645094
/// </summary>
public abstract class unclassified_Arothron : Arothron, Iunclassified_Arothron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arothron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645094;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arothron";
}
