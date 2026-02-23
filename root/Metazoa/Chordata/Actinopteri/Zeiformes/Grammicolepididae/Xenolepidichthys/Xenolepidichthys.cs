using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae.Xenolepidichthys;

/// <summary>
/// Abstract class for Xenolepidichthys (genus).
/// NCBI TaxId: 390382
/// </summary>
public abstract class Xenolepidichthys : Grammicolepididae, IXenolepidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenolepidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390382;

    /// <inheritdoc />
    public virtual string GenusName => "Xenolepidichthys";

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
