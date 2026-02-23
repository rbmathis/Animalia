using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Malayochela;

/// <summary>
/// Abstract class for Malayochela (genus).
/// NCBI TaxId: 1142228
/// </summary>
public abstract class Malayochela : Danionidae, IMalayochela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malayochela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1142228;

    /// <inheritdoc />
    public virtual string GenusName => "Malayochela";

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
