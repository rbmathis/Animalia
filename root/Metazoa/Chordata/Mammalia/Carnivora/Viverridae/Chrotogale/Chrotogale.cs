using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Chrotogale;

/// <summary>
/// Abstract class for Chrotogale (genus).
/// NCBI TaxId: 94183
/// </summary>
public abstract class Chrotogale : Viverridae, IChrotogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrotogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94183;

    /// <inheritdoc />
    public virtual string GenusName => "Chrotogale";

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
