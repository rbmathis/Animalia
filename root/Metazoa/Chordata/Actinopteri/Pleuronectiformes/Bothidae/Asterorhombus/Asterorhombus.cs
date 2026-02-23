using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Asterorhombus;

/// <summary>
/// Abstract class for Asterorhombus (genus).
/// NCBI TaxId: 1286166
/// </summary>
public abstract class Asterorhombus : Bothidae, IAsterorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asterorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1286166;

    /// <inheritdoc />
    public virtual string GenusName => "Asterorhombus";

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
