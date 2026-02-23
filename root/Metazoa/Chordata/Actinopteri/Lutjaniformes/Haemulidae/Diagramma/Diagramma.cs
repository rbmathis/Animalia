using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Diagramma;

/// <summary>
/// Abstract class for Diagramma (genus).
/// NCBI TaxId: 241257
/// </summary>
public abstract class Diagramma : Haemulidae, IDiagramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diagramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241257;

    /// <inheritdoc />
    public virtual string GenusName => "Diagramma";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
