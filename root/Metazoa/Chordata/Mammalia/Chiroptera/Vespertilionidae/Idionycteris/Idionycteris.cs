using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Idionycteris;

/// <summary>
/// Abstract class for Idionycteris (genus).
/// NCBI TaxId: 27664
/// </summary>
public abstract class Idionycteris : Vespertilionidae, IIdionycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idionycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27664;

    /// <inheritdoc />
    public virtual string GenusName => "Idionycteris";

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
