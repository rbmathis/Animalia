using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae.Anoplocapros;

/// <summary>
/// Abstract class for Anoplocapros (genus).
/// NCBI TaxId: 303733
/// </summary>
public abstract class Anoplocapros : Aracanidae, IAnoplocapros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoplocapros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303733;

    /// <inheritdoc />
    public virtual string GenusName => "Anoplocapros";

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
