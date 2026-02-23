using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Simalia;

/// <summary>
/// Abstract class for Simalia (genus).
/// NCBI TaxId: 1497996
/// </summary>
public abstract class Simalia : Pythonidae, ISimalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1497996;

    /// <inheritdoc />
    public virtual string GenusName => "Simalia";

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
