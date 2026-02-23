using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Microdevario;

/// <summary>
/// Abstract class for Microdevario (genus).
/// NCBI TaxId: 857697
/// </summary>
public abstract class Microdevario : Danionidae, IMicrodevario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microdevario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 857697;

    /// <inheritdoc />
    public virtual string GenusName => "Microdevario";

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
