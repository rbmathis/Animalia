using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neocentropogon;

/// <summary>
/// Abstract class for Neocentropogon (genus).
/// NCBI TaxId: 1188037
/// </summary>
public abstract class Neocentropogon : Scorpaenidae, INeocentropogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocentropogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1188037;

    /// <inheritdoc />
    public virtual string GenusName => "Neocentropogon";

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
