using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Ricuzenius;

/// <summary>
/// Abstract class for Ricuzenius (genus).
/// NCBI TaxId: 1633514
/// </summary>
public abstract class Ricuzenius : Cottidae, IRicuzenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ricuzenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633514;

    /// <inheritdoc />
    public virtual string GenusName => "Ricuzenius";

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
