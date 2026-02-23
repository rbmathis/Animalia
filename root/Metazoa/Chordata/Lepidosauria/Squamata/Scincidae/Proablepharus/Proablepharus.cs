using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Proablepharus;

/// <summary>
/// Abstract class for Proablepharus (genus).
/// NCBI TaxId: 1041600
/// </summary>
public abstract class Proablepharus : Scincidae, IProablepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041600;

    /// <inheritdoc />
    public virtual string GenusName => "Proablepharus";

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
