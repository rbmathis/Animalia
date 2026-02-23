using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Euchoreutes;

/// <summary>
/// Abstract class for Euchoreutes (genus).
/// NCBI TaxId: 980893
/// </summary>
public abstract class Euchoreutes : Dipodidae, IEuchoreutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euchoreutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980893;

    /// <inheritdoc />
    public virtual string GenusName => "Euchoreutes";

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
