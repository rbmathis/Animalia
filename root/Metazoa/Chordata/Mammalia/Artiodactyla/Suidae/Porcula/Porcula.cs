using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Porcula;

/// <summary>
/// Abstract class for Porcula (genus).
/// NCBI TaxId: 476283
/// </summary>
public abstract class Porcula : Suidae, IPorcula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porcula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 476283;

    /// <inheritdoc />
    public virtual string GenusName => "Porcula";

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
