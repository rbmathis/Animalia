using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Nycticebus;

/// <summary>
/// Abstract class for Nycticebus (genus).
/// NCBI TaxId: 9469
/// </summary>
public abstract class Nycticebus : Lorisidae, INycticebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycticebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9469;

    /// <inheritdoc />
    public virtual string GenusName => "Nycticebus";

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
