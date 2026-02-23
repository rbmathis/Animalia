using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prionobrama;

/// <summary>
/// Abstract class for Prionobrama (genus).
/// NCBI TaxId: 930398
/// </summary>
public abstract class Prionobrama : Characidae, IPrionobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930398;

    /// <inheritdoc />
    public virtual string GenusName => "Prionobrama";

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
