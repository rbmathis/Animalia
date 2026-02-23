using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

/// <summary>
/// Abstract class for Platichthys (genus).
/// NCBI TaxId: 8259
/// </summary>
public abstract class Platichthys : Pleuronectidae, IPlatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8259;

    /// <inheritdoc />
    public virtual string GenusName => "Platichthys";

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
