using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Thoopterus;

/// <summary>
/// Abstract class for Thoopterus (genus).
/// NCBI TaxId: 58086
/// </summary>
public abstract class Thoopterus : Pteropodidae, IThoopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thoopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58086;

    /// <inheritdoc />
    public virtual string GenusName => "Thoopterus";

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
