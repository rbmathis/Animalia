using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lepidophanes;

/// <summary>
/// Abstract class for Lepidophanes (genus).
/// NCBI TaxId: 123252
/// </summary>
public abstract class Lepidophanes : Myctophidae, ILepidophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123252;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidophanes";

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
