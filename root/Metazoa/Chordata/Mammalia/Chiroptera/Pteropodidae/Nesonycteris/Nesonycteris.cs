using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nesonycteris;

/// <summary>
/// Abstract class for Nesonycteris (genus).
/// NCBI TaxId: 3371070
/// </summary>
public abstract class Nesonycteris : Pteropodidae, INesonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371070;

    /// <inheritdoc />
    public virtual string GenusName => "Nesonycteris";

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
