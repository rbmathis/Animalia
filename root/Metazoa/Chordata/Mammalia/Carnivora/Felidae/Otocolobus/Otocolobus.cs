using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Otocolobus;

/// <summary>
/// Abstract class for Otocolobus (genus).
/// NCBI TaxId: 61407
/// </summary>
public abstract class Otocolobus : Felidae, IOtocolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otocolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61407;

    /// <inheritdoc />
    public virtual string GenusName => "Otocolobus";

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
