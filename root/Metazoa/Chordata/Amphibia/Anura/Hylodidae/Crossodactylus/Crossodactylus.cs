using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Crossodactylus;

/// <summary>
/// Abstract class for Crossodactylus (genus).
/// NCBI TaxId: 209667
/// </summary>
public abstract class Crossodactylus : Hylodidae, ICrossodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209667;

    /// <inheritdoc />
    public virtual string GenusName => "Crossodactylus";

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
