using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Ablabys;

/// <summary>
/// Abstract class for Ablabys (genus).
/// NCBI TaxId: 274715
/// </summary>
public abstract class Ablabys : Tetrarogidae, IAblabys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ablabys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274715;

    /// <inheritdoc />
    public virtual string GenusName => "Ablabys";

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
