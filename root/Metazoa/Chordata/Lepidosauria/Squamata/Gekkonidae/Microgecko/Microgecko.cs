using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Microgecko;

/// <summary>
/// Abstract class for Microgecko (genus).
/// NCBI TaxId: 1353229
/// </summary>
public abstract class Microgecko : Gekkonidae, IMicrogecko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgecko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1353229;

    /// <inheritdoc />
    public virtual string GenusName => "Microgecko";

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
