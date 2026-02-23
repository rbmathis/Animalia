using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Typhlichthys;

/// <summary>
/// Abstract class for Typhlichthys (genus).
/// NCBI TaxId: 940469
/// </summary>
public abstract class Typhlichthys : Amblyopsidae, ITyphlichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 940469;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlichthys";

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
