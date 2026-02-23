using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Forbesichthys;

/// <summary>
/// Abstract class for Forbesichthys (genus).
/// NCBI TaxId: 940465
/// </summary>
public abstract class Forbesichthys : Amblyopsidae, IForbesichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Forbesichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 940465;

    /// <inheritdoc />
    public virtual string GenusName => "Forbesichthys";

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
