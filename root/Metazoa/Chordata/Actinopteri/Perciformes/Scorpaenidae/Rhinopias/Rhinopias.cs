using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Rhinopias;

/// <summary>
/// Abstract class for Rhinopias (genus).
/// NCBI TaxId: 1609621
/// </summary>
public abstract class Rhinopias : Scorpaenidae, IRhinopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609621;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinopias";

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
