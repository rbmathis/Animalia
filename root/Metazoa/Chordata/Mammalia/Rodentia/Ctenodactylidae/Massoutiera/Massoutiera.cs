using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae.Massoutiera;

/// <summary>
/// Abstract class for Massoutiera (genus).
/// NCBI TaxId: 92482
/// </summary>
public abstract class Massoutiera : Ctenodactylidae, IMassoutiera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Massoutiera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 92482;

    /// <inheritdoc />
    public virtual string GenusName => "Massoutiera";

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
