using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Antilope;

/// <summary>
/// Abstract class for Antilope (genus).
/// NCBI TaxId: 59524
/// </summary>
public abstract class Antilope : Bovidae, IAntilope
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antilope";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59524;

    /// <inheritdoc />
    public virtual string GenusName => "Antilope";

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
