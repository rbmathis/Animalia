using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Parapterois;

/// <summary>
/// Abstract class for Parapterois (genus).
/// NCBI TaxId: 1585662
/// </summary>
public abstract class Parapterois : Scorpaenidae, IParapterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1585662;

    /// <inheritdoc />
    public virtual string GenusName => "Parapterois";

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
