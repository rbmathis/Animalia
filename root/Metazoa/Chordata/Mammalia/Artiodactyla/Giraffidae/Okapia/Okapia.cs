using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Okapia;

/// <summary>
/// Abstract class for Okapia (genus).
/// NCBI TaxId: 86972
/// </summary>
public abstract class Okapia : Giraffidae, IOkapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Okapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86972;

    /// <inheritdoc />
    public virtual string GenusName => "Okapia";

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
