using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Paranyctimene;

/// <summary>
/// Abstract class for Paranyctimene (genus).
/// NCBI TaxId: 270784
/// </summary>
public abstract class Paranyctimene : Pteropodidae, IParanyctimene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranyctimene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270784;

    /// <inheritdoc />
    public virtual string GenusName => "Paranyctimene";

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
