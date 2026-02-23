using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pseudopleuronectes;

/// <summary>
/// Abstract class for Pseudopleuronectes (genus).
/// NCBI TaxId: 8264
/// </summary>
public abstract class Pseudopleuronectes : Pleuronectidae, IPseudopleuronectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopleuronectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8264;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopleuronectes";

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
