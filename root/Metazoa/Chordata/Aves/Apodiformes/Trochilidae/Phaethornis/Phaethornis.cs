using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phaethornis;

/// <summary>
/// Abstract class for Phaethornis (genus).
/// NCBI TaxId: 46512
/// </summary>
public abstract class Phaethornis : Trochilidae, IPhaethornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaethornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46512;

    /// <inheritdoc />
    public virtual string GenusName => "Phaethornis";

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
