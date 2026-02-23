using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Piliocolobus;

/// <summary>
/// Abstract class for Piliocolobus (genus).
/// NCBI TaxId: 591932
/// </summary>
public abstract class Piliocolobus : Cercopithecidae, IPiliocolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piliocolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591932;

    /// <inheritdoc />
    public virtual string GenusName => "Piliocolobus";

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
