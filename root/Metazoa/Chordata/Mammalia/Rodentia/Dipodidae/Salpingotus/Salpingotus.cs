using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Salpingotus;

/// <summary>
/// Abstract class for Salpingotus (genus).
/// NCBI TaxId: 1041414
/// </summary>
public abstract class Salpingotus : Dipodidae, ISalpingotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salpingotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041414;

    /// <inheritdoc />
    public virtual string GenusName => "Salpingotus";

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
