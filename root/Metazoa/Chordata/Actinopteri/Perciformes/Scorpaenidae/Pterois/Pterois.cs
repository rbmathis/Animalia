using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Pterois;

/// <summary>
/// Abstract class for Pterois (genus).
/// NCBI TaxId: 185881
/// </summary>
public abstract class Pterois : Scorpaenidae, IPterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185881;

    /// <inheritdoc />
    public virtual string GenusName => "Pterois";

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
