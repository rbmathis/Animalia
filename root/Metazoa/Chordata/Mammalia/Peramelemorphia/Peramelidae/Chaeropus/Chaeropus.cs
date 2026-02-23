using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Chaeropus;

/// <summary>
/// Abstract class for Chaeropus (genus).
/// NCBI TaxId: 92648
/// </summary>
public abstract class Chaeropus : Peramelidae, IChaeropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaeropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 92648;

    /// <inheritdoc />
    public virtual string GenusName => "Chaeropus";

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
