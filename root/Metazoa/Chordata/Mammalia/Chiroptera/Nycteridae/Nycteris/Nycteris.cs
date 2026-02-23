using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris;

/// <summary>
/// Abstract class for Nycteris (genus).
/// NCBI TaxId: 59466
/// </summary>
public abstract class Nycteris : Nycteridae, INycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59466;

    /// <inheritdoc />
    public virtual string GenusName => "Nycteris";

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
