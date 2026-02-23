using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Apocryptodon;

/// <summary>
/// Abstract class for Apocryptodon (genus).
/// NCBI TaxId: 1365672
/// </summary>
public abstract class Apocryptodon : Gobiidae, IApocryptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apocryptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365672;

    /// <inheritdoc />
    public virtual string GenusName => "Apocryptodon";

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
