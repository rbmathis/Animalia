using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Hydrurga;

/// <summary>
/// Abstract class for Hydrurga (genus).
/// NCBI TaxId: 29085
/// </summary>
public abstract class Hydrurga : Phocidae, IHydrurga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrurga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29085;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrurga";

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
