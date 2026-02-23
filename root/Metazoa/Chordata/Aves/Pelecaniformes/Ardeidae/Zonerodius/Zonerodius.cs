using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Zonerodius;

/// <summary>
/// Abstract class for Zonerodius (genus).
/// NCBI TaxId: 2767385
/// </summary>
public abstract class Zonerodius : Ardeidae, IZonerodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zonerodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767385;

    /// <inheritdoc />
    public virtual string GenusName => "Zonerodius";

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
