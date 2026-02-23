using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neochirus;

/// <summary>
/// Abstract class for Neochirus (genus).
/// NCBI TaxId: 3051943
/// </summary>
public abstract class Neochirus : Scorpaenidae, INeochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051943;

    /// <inheritdoc />
    public virtual string GenusName => "Neochirus";

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
