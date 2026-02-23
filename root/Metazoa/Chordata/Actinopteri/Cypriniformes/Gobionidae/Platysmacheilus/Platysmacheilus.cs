using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Platysmacheilus;

/// <summary>
/// Abstract class for Platysmacheilus (genus).
/// NCBI TaxId: 328545
/// </summary>
public abstract class Platysmacheilus : Gobionidae, IPlatysmacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platysmacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328545;

    /// <inheritdoc />
    public virtual string GenusName => "Platysmacheilus";

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
