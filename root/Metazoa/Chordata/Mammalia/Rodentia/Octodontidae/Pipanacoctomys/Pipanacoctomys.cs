using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Pipanacoctomys;

/// <summary>
/// Abstract class for Pipanacoctomys (genus).
/// NCBI TaxId: 227729
/// </summary>
public abstract class Pipanacoctomys : Octodontidae, IPipanacoctomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipanacoctomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227729;

    /// <inheritdoc />
    public virtual string GenusName => "Pipanacoctomys";

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
