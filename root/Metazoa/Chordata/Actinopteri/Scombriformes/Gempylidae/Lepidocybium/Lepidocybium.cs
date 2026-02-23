using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Lepidocybium;

/// <summary>
/// Abstract class for Lepidocybium (genus).
/// NCBI TaxId: 13586
/// </summary>
public abstract class Lepidocybium : Gempylidae, ILepidocybium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidocybium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13586;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidocybium";

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
