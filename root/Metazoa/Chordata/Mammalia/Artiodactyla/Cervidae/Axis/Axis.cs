using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Axis;

/// <summary>
/// Abstract class for Axis (genus).
/// NCBI TaxId: 9855
/// </summary>
public abstract class Axis : Cervidae, IAxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Axis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9855;

    /// <inheritdoc />
    public virtual string GenusName => "Axis";

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
