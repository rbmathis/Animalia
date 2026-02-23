using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Babyrousa;

/// <summary>
/// Abstract class for Babyrousa (genus).
/// NCBI TaxId: 41805
/// </summary>
public abstract class Babyrousa : Suidae, IBabyrousa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Babyrousa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41805;

    /// <inheritdoc />
    public virtual string GenusName => "Babyrousa";

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
