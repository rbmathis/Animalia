using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Parazen;

/// <summary>
/// Abstract class for Parazen (genus).
/// NCBI TaxId: 181439
/// </summary>
public abstract class Parazen : Parazenidae, IParazen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parazen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181439;

    /// <inheritdoc />
    public virtual string GenusName => "Parazen";

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
