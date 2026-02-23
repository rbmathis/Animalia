using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Nanobagrus;

/// <summary>
/// Abstract class for Nanobagrus (genus).
/// NCBI TaxId: 337727
/// </summary>
public abstract class Nanobagrus : Bagridae, INanobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337727;

    /// <inheritdoc />
    public virtual string GenusName => "Nanobagrus";

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
