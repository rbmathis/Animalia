using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danionella;

/// <summary>
/// Abstract class for Danionella (genus).
/// NCBI TaxId: 432408
/// </summary>
public abstract class Danionella : Danionidae, IDanionella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Danionella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432408;

    /// <inheritdoc />
    public virtual string GenusName => "Danionella";

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
