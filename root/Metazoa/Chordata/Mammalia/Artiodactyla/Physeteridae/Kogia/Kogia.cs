using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae.Kogia;

/// <summary>
/// Abstract class for Kogia (genus).
/// NCBI TaxId: 9751
/// </summary>
public abstract class Kogia : Physeteridae, IKogia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kogia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9751;

    /// <inheritdoc />
    public virtual string GenusName => "Kogia";

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
