using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Kottelatlimia;

/// <summary>
/// Abstract class for Kottelatlimia (genus).
/// NCBI TaxId: 457522
/// </summary>
public abstract class Kottelatlimia : Cobitidae, IKottelatlimia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kottelatlimia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457522;

    /// <inheritdoc />
    public virtual string GenusName => "Kottelatlimia";

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
