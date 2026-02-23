using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Trigonodactylus;

/// <summary>
/// Abstract class for Trigonodactylus (genus).
/// NCBI TaxId: 2546785
/// </summary>
public abstract class Trigonodactylus : Gekkonidae, ITrigonodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546785;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonodactylus";

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
