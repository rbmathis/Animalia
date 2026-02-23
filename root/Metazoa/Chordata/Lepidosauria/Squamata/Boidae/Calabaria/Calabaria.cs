using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Calabaria;

/// <summary>
/// Abstract class for Calabaria (genus).
/// NCBI TaxId: 196254
/// </summary>
public abstract class Calabaria : Boidae, ICalabaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calabaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196254;

    /// <inheritdoc />
    public virtual string GenusName => "Calabaria";

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
