using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Radulinopsis;

/// <summary>
/// Abstract class for Radulinopsis (genus).
/// NCBI TaxId: 1633506
/// </summary>
public abstract class Radulinopsis : Cottidae, IRadulinopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Radulinopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633506;

    /// <inheritdoc />
    public virtual string GenusName => "Radulinopsis";

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
