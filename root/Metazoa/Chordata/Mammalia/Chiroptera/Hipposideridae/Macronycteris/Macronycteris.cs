using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Macronycteris;

/// <summary>
/// Abstract class for Macronycteris (genus).
/// NCBI TaxId: 2603868
/// </summary>
public abstract class Macronycteris : Hipposideridae, IMacronycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macronycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2603868;

    /// <inheritdoc />
    public virtual string GenusName => "Macronycteris";

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
