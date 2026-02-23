using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Diagramma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Diagramma.unclassified_Diagramma;

/// <summary>
/// Abstract class for unclassified Diagramma (no rank).
/// NCBI TaxId: 2618794
/// </summary>
public abstract class unclassified_Diagramma : Diagramma, Iunclassified_Diagramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diagramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618794;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diagramma";
}
