using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudoryx;

/// <summary>
/// Abstract class for Pseudoryx (genus).
/// NCBI TaxId: 97362
/// </summary>
public abstract class Pseudoryx : Bovidae, IPseudoryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97362;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoryx";

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
