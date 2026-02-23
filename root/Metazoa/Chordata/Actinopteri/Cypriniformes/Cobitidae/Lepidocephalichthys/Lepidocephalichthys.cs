using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Lepidocephalichthys;

/// <summary>
/// Abstract class for Lepidocephalichthys (genus).
/// NCBI TaxId: 425478
/// </summary>
public abstract class Lepidocephalichthys : Cobitidae, ILepidocephalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidocephalichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425478;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidocephalichthys";

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
