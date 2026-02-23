using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Xenomedea;

/// <summary>
/// Abstract class for Xenomedea (genus).
/// NCBI TaxId: 879901
/// </summary>
public abstract class Xenomedea : Labrisomidae, IXenomedea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenomedea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879901;

    /// <inheritdoc />
    public virtual string GenusName => "Xenomedea";

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
