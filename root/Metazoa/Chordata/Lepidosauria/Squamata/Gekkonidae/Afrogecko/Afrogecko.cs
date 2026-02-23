using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Afrogecko;

/// <summary>
/// Abstract class for Afrogecko (genus).
/// NCBI TaxId: 221550
/// </summary>
public abstract class Afrogecko : Gekkonidae, IAfrogecko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afrogecko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221550;

    /// <inheritdoc />
    public virtual string GenusName => "Afrogecko";

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
