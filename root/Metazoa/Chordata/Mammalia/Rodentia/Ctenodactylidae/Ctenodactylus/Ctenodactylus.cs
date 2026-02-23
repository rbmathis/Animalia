using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae.Ctenodactylus;

/// <summary>
/// Abstract class for Ctenodactylus (genus).
/// NCBI TaxId: 10165
/// </summary>
public abstract class Ctenodactylus : Ctenodactylidae, ICtenodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10165;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenodactylus";

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
