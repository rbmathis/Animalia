using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Morelia;

/// <summary>
/// Abstract class for Morelia (genus).
/// NCBI TaxId: 51894
/// </summary>
public abstract class Morelia : Pythonidae, IMorelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51894;

    /// <inheritdoc />
    public virtual string GenusName => "Morelia";

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
