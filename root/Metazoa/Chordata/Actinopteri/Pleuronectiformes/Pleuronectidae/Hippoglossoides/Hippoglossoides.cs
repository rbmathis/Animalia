using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hippoglossoides;

/// <summary>
/// Abstract class for Hippoglossoides (genus).
/// NCBI TaxId: 30944
/// </summary>
public abstract class Hippoglossoides : Pleuronectidae, IHippoglossoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippoglossoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30944;

    /// <inheritdoc />
    public virtual string GenusName => "Hippoglossoides";

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
