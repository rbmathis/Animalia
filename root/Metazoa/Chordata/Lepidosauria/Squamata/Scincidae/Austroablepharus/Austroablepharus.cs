using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Austroablepharus;

/// <summary>
/// Abstract class for Austroablepharus (genus).
/// NCBI TaxId: 2593636
/// </summary>
public abstract class Austroablepharus : Scincidae, IAustroablepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austroablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2593636;

    /// <inheritdoc />
    public virtual string GenusName => "Austroablepharus";

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
