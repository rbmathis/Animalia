using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Gigarcanum;

/// <summary>
/// Abstract class for Gigarcanum (genus).
/// NCBI TaxId: 3148934
/// </summary>
public abstract class Gigarcanum : Diplodactylidae, IGigarcanum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gigarcanum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148934;

    /// <inheritdoc />
    public virtual string GenusName => "Gigarcanum";

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
