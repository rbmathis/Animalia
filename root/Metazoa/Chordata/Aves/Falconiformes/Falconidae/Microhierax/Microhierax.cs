using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Microhierax;

/// <summary>
/// Abstract class for Microhierax (genus).
/// NCBI TaxId: 56340
/// </summary>
public abstract class Microhierax : Falconidae, IMicrohierax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microhierax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56340;

    /// <inheritdoc />
    public virtual string GenusName => "Microhierax";

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
