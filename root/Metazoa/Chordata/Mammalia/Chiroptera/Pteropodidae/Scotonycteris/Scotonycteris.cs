using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Scotonycteris;

/// <summary>
/// Abstract class for Scotonycteris (genus).
/// NCBI TaxId: 1001562
/// </summary>
public abstract class Scotonycteris : Pteropodidae, IScotonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1001562;

    /// <inheritdoc />
    public virtual string GenusName => "Scotonycteris";

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
