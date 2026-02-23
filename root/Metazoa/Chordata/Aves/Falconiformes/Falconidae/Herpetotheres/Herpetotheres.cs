using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Herpetotheres;

/// <summary>
/// Abstract class for Herpetotheres (genus).
/// NCBI TaxId: 56342
/// </summary>
public abstract class Herpetotheres : Falconidae, IHerpetotheres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herpetotheres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56342;

    /// <inheritdoc />
    public virtual string GenusName => "Herpetotheres";

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
