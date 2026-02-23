using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Microrasbora;

/// <summary>
/// Abstract class for Microrasbora (genus).
/// NCBI TaxId: 432416
/// </summary>
public abstract class Microrasbora : Danionidae, IMicrorasbora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microrasbora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432416;

    /// <inheritdoc />
    public virtual string GenusName => "Microrasbora";

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
