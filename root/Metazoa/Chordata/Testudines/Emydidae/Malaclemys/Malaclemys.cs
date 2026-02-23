using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Malaclemys;

/// <summary>
/// Abstract class for Malaclemys (genus).
/// NCBI TaxId: 8484
/// </summary>
public abstract class Malaclemys : Emydidae, IMalaclemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malaclemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8484;

    /// <inheritdoc />
    public virtual string GenusName => "Malaclemys";

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
