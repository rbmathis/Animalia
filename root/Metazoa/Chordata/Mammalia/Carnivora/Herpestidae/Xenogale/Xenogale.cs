using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Xenogale;

/// <summary>
/// Abstract class for Xenogale (genus).
/// NCBI TaxId: 3082989
/// </summary>
public abstract class Xenogale : Herpestidae, IXenogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3082989;

    /// <inheritdoc />
    public virtual string GenusName => "Xenogale";

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
