using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Abstract class for Kobus (genus).
/// NCBI TaxId: 9961
/// </summary>
public abstract class Kobus : Bovidae, IKobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9961;

    /// <inheritdoc />
    public virtual string GenusName => "Kobus";

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
