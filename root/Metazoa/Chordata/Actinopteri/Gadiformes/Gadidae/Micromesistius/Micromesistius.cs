using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Micromesistius;

/// <summary>
/// Abstract class for Micromesistius (genus).
/// NCBI TaxId: 81635
/// </summary>
public abstract class Micromesistius : Gadidae, IMicromesistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromesistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81635;

    /// <inheritdoc />
    public virtual string GenusName => "Micromesistius";

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
