using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Eonycteris;

/// <summary>
/// Abstract class for Eonycteris (genus).
/// NCBI TaxId: 58064
/// </summary>
public abstract class Eonycteris : Pteropodidae, IEonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58064;

    /// <inheritdoc />
    public virtual string GenusName => "Eonycteris";

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
