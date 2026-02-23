using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Torontoceros;

/// <summary>
/// Abstract class for Torontoceros (genus).
/// NCBI TaxId: 3235072
/// </summary>
public abstract class Torontoceros : Cervidae, ITorontoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Torontoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3235072;

    /// <inheritdoc />
    public virtual string GenusName => "Torontoceros";

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
