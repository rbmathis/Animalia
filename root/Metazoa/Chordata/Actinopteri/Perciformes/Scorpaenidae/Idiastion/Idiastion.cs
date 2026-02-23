using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Idiastion;

/// <summary>
/// Abstract class for Idiastion (genus).
/// NCBI TaxId: 1609619
/// </summary>
public abstract class Idiastion : Scorpaenidae, IIdiastion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiastion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609619;

    /// <inheritdoc />
    public virtual string GenusName => "Idiastion";

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
