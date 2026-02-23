using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Brama;

/// <summary>
/// Abstract class for Brama (genus).
/// NCBI TaxId: 215351
/// </summary>
public abstract class Brama : Bramidae, IBrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215351;

    /// <inheritdoc />
    public virtual string GenusName => "Brama";

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
