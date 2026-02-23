using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Dendrochirus;

/// <summary>
/// Abstract class for Dendrochirus (genus).
/// NCBI TaxId: 94307
/// </summary>
public abstract class Dendrochirus : Scorpaenidae, IDendrochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94307;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrochirus";

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
