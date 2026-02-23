using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Pseudoblennius;

/// <summary>
/// Abstract class for Pseudoblennius (genus).
/// NCBI TaxId: 1508109
/// </summary>
public abstract class Pseudoblennius : Cottidae, IPseudoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1508109;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoblennius";

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
