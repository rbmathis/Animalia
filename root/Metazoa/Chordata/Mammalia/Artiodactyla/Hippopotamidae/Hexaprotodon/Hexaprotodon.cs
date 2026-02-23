using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hexaprotodon;

/// <summary>
/// Abstract class for Hexaprotodon (genus).
/// NCBI TaxId: 56797
/// </summary>
public abstract class Hexaprotodon : Hippopotamidae, IHexaprotodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hexaprotodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56797;

    /// <inheritdoc />
    public virtual string GenusName => "Hexaprotodon";

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
