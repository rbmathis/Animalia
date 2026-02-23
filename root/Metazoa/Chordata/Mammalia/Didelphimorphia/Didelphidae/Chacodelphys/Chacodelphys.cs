using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Chacodelphys;

/// <summary>
/// Abstract class for Chacodelphys (genus).
/// NCBI TaxId: 1819354
/// </summary>
public abstract class Chacodelphys : Didelphidae, IChacodelphys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chacodelphys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1819354;

    /// <inheritdoc />
    public virtual string GenusName => "Chacodelphys";

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
