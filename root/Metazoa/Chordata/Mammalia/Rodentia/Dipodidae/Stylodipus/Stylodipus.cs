using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Stylodipus;

/// <summary>
/// Abstract class for Stylodipus (genus).
/// NCBI TaxId: 1041412
/// </summary>
public abstract class Stylodipus : Dipodidae, IStylodipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stylodipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041412;

    /// <inheritdoc />
    public virtual string GenusName => "Stylodipus";

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
