using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Lepidopygopsis;

/// <summary>
/// Abstract class for Lepidopygopsis (genus).
/// NCBI TaxId: 1389699
/// </summary>
public abstract class Lepidopygopsis : Cyprinidae, ILepidopygopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidopygopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1389699;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidopygopsis";

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
