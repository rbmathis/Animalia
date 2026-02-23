using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Alionycteris;

/// <summary>
/// Abstract class for Alionycteris (genus).
/// NCBI TaxId: 662936
/// </summary>
public abstract class Alionycteris : Pteropodidae, IAlionycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alionycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 662936;

    /// <inheritdoc />
    public virtual string GenusName => "Alionycteris";

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
