using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus;

/// <summary>
/// Abstract class for Bradypus (genus).
/// NCBI TaxId: 9353
/// </summary>
public abstract class Bradypus : Bradypodidae, IBradypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bradypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9353;

    /// <inheritdoc />
    public virtual string GenusName => "Bradypus";

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
