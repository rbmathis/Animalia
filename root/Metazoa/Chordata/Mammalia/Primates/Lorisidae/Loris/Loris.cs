using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Loris;

/// <summary>
/// Abstract class for Loris (genus).
/// NCBI TaxId: 9467
/// </summary>
public abstract class Loris : Lorisidae, ILoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9467;

    /// <inheritdoc />
    public virtual string GenusName => "Loris";

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
