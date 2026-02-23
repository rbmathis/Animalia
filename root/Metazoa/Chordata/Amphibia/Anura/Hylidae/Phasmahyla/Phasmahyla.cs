using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phasmahyla;

/// <summary>
/// Abstract class for Phasmahyla (genus).
/// NCBI TaxId: 318405
/// </summary>
public abstract class Phasmahyla : Hylidae, IPhasmahyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasmahyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318405;

    /// <inheritdoc />
    public virtual string GenusName => "Phasmahyla";

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
