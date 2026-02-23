using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Syconycteris;

/// <summary>
/// Abstract class for Syconycteris (genus).
/// NCBI TaxId: 58084
/// </summary>
public abstract class Syconycteris : Pteropodidae, ISyconycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syconycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58084;

    /// <inheritdoc />
    public virtual string GenusName => "Syconycteris";

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
