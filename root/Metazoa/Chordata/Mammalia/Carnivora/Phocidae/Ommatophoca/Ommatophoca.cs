using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Ommatophoca;

/// <summary>
/// Abstract class for Ommatophoca (genus).
/// NCBI TaxId: 207341
/// </summary>
public abstract class Ommatophoca : Phocidae, IOmmatophoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ommatophoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 207341;

    /// <inheritdoc />
    public virtual string GenusName => "Ommatophoca";

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
