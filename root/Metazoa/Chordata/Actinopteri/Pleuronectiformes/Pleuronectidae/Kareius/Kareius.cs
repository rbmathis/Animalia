using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Kareius;

/// <summary>
/// Abstract class for Kareius (genus).
/// NCBI TaxId: 468930
/// </summary>
public abstract class Kareius : Pleuronectidae, IKareius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kareius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 468930;

    /// <inheritdoc />
    public virtual string GenusName => "Kareius";

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
