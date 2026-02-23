using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heliophobius;

/// <summary>
/// Abstract class for Heliophobius (genus).
/// NCBI TaxId: 10178
/// </summary>
public abstract class Heliophobius : Bathyergidae, IHeliophobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliophobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10178;

    /// <inheritdoc />
    public virtual string GenusName => "Heliophobius";

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
