using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Acerodon;

/// <summary>
/// Abstract class for Acerodon (genus).
/// NCBI TaxId: 58056
/// </summary>
public abstract class Acerodon : Pteropodidae, IAcerodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acerodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58056;

    /// <inheritdoc />
    public virtual string GenusName => "Acerodon";

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
