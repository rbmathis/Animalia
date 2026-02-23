using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Craseonycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Craseonycteridae.Craseonycteris;

/// <summary>
/// Abstract class for Craseonycteris (genus).
/// NCBI TaxId: 208971
/// </summary>
public abstract class Craseonycteris : Craseonycteridae, ICraseonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craseonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208971;

    /// <inheritdoc />
    public virtual string GenusName => "Craseonycteris";

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
