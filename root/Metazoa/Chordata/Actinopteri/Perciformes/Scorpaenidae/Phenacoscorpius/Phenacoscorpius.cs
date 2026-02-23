using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Phenacoscorpius;

/// <summary>
/// Abstract class for Phenacoscorpius (genus).
/// NCBI TaxId: 1916826
/// </summary>
public abstract class Phenacoscorpius : Scorpaenidae, IPhenacoscorpius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacoscorpius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916826;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacoscorpius";

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
