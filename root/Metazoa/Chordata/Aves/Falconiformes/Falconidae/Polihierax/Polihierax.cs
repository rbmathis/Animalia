using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Polihierax;

/// <summary>
/// Abstract class for Polihierax (genus).
/// NCBI TaxId: 56338
/// </summary>
public abstract class Polihierax : Falconidae, IPolihierax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polihierax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56338;

    /// <inheritdoc />
    public virtual string GenusName => "Polihierax";

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
