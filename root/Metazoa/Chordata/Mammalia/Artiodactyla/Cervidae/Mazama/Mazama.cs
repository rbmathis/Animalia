using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama;

/// <summary>
/// Abstract class for Mazama (genus).
/// NCBI TaxId: 43333
/// </summary>
public abstract class Mazama : Cervidae, IMazama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mazama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43333;

    /// <inheritdoc />
    public virtual string GenusName => "Mazama";

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
