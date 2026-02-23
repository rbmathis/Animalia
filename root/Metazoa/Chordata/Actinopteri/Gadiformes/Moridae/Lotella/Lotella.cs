using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Lotella;

/// <summary>
/// Abstract class for Lotella (genus).
/// NCBI TaxId: 443791
/// </summary>
public abstract class Lotella : Moridae, ILotella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lotella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443791;

    /// <inheritdoc />
    public virtual string GenusName => "Lotella";

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
