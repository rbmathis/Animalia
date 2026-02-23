using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Afroablepharus;

/// <summary>
/// Abstract class for Afroablepharus (genus).
/// NCBI TaxId: 245593
/// </summary>
public abstract class Afroablepharus : Scincidae, IAfroablepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afroablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245593;

    /// <inheritdoc />
    public virtual string GenusName => "Afroablepharus";

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
