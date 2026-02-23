using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Lepidocephalus;

/// <summary>
/// Abstract class for Lepidocephalus (genus).
/// NCBI TaxId: 209154
/// </summary>
public abstract class Lepidocephalus : Cobitidae, ILepidocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209154;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidocephalus";

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
