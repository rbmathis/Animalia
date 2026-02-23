using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Bdeogale;

/// <summary>
/// Abstract class for Bdeogale (genus).
/// NCBI TaxId: 326575
/// </summary>
public abstract class Bdeogale : Herpestidae, IBdeogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bdeogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326575;

    /// <inheritdoc />
    public virtual string GenusName => "Bdeogale";

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
