using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Tylonycteris;

/// <summary>
/// Abstract class for Tylonycteris (genus).
/// NCBI TaxId: 258958
/// </summary>
public abstract class Tylonycteris : Vespertilionidae, ITylonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258958;

    /// <inheritdoc />
    public virtual string GenusName => "Tylonycteris";

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
