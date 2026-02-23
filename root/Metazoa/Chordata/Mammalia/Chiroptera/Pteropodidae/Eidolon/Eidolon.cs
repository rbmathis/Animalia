using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Eidolon;

/// <summary>
/// Abstract class for Eidolon (genus).
/// NCBI TaxId: 58062
/// </summary>
public abstract class Eidolon : Pteropodidae, IEidolon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eidolon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58062;

    /// <inheritdoc />
    public virtual string GenusName => "Eidolon";

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
