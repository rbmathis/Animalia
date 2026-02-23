using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Neogale;

/// <summary>
/// Abstract class for Neogale (genus).
/// NCBI TaxId: 2902005
/// </summary>
public abstract class Neogale : Mustelidae, INeogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2902005;

    /// <inheritdoc />
    public virtual string GenusName => "Neogale";

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
