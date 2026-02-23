using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Latidens;

/// <summary>
/// Abstract class for Latidens (genus).
/// NCBI TaxId: 556918
/// </summary>
public abstract class Latidens : Pteropodidae, ILatidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556918;

    /// <inheritdoc />
    public virtual string GenusName => "Latidens";

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
