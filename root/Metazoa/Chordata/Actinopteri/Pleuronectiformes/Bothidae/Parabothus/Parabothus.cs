using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Parabothus;

/// <summary>
/// Abstract class for Parabothus (genus).
/// NCBI TaxId: 366899
/// </summary>
public abstract class Parabothus : Bothidae, IParabothus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabothus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366899;

    /// <inheritdoc />
    public virtual string GenusName => "Parabothus";

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
