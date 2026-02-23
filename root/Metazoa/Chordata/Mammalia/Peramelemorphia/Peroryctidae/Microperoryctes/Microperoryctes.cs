using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Microperoryctes;

/// <summary>
/// Abstract class for Microperoryctes (genus).
/// NCBI TaxId: 38628
/// </summary>
public abstract class Microperoryctes : Peroryctidae, IMicroperoryctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microperoryctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38628;

    /// <inheritdoc />
    public virtual string GenusName => "Microperoryctes";

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
