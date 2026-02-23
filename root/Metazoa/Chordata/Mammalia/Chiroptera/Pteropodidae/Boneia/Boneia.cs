using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Boneia;

/// <summary>
/// Abstract class for Boneia (genus).
/// NCBI TaxId: 270781
/// </summary>
public abstract class Boneia : Pteropodidae, IBoneia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boneia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270781;

    /// <inheritdoc />
    public virtual string GenusName => "Boneia";

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
