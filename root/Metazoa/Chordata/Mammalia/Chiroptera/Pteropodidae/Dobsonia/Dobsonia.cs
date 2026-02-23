using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Dobsonia;

/// <summary>
/// Abstract class for Dobsonia (genus).
/// NCBI TaxId: 42146
/// </summary>
public abstract class Dobsonia : Pteropodidae, IDobsonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dobsonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42146;

    /// <inheritdoc />
    public virtual string GenusName => "Dobsonia";

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
