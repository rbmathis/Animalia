using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nanonycteris;

/// <summary>
/// Abstract class for Nanonycteris (genus).
/// NCBI TaxId: 498219
/// </summary>
public abstract class Nanonycteris : Pteropodidae, INanonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 498219;

    /// <inheritdoc />
    public virtual string GenusName => "Nanonycteris";

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
