using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Osphranter;

/// <summary>
/// Abstract class for Osphranter (genus).
/// NCBI TaxId: 2182372
/// </summary>
public abstract class Osphranter : Macropodidae, IOsphranter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osphranter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2182372;

    /// <inheritdoc />
    public virtual string GenusName => "Osphranter";

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
