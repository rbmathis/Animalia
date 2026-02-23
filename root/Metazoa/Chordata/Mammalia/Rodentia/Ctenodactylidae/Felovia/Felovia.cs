using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae.Felovia;

/// <summary>
/// Abstract class for Felovia (genus).
/// NCBI TaxId: 1654793
/// </summary>
public abstract class Felovia : Ctenodactylidae, IFelovia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Felovia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1654793;

    /// <inheritdoc />
    public virtual string GenusName => "Felovia";

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
