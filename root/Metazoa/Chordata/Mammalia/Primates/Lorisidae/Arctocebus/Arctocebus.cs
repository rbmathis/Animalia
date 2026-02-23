using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Arctocebus;

/// <summary>
/// Abstract class for Arctocebus (genus).
/// NCBI TaxId: 261738
/// </summary>
public abstract class Arctocebus : Lorisidae, IArctocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261738;

    /// <inheritdoc />
    public virtual string GenusName => "Arctocebus";

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
