using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Centronycteris;

/// <summary>
/// Abstract class for Centronycteris (genus).
/// NCBI TaxId: 461396
/// </summary>
public abstract class Centronycteris : Emballonuridae, ICentronycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centronycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461396;

    /// <inheritdoc />
    public virtual string GenusName => "Centronycteris";

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
