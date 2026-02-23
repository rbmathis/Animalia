using AnimalKingdom.root.Metazoa.Chordata.Aves.Phaethontiformes.Phaethontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phaethontiformes.Phaethontidae.Phaethon;

/// <summary>
/// Abstract class for Phaethon (genus).
/// NCBI TaxId: 37044
/// </summary>
public abstract class Phaethon : Phaethontidae, IPhaethon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaethon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37044;

    /// <inheritdoc />
    public virtual string GenusName => "Phaethon";

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
