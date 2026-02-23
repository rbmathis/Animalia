using AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicopterus;

/// <summary>
/// Abstract class for Phoenicopterus (genus).
/// NCBI TaxId: 9216
/// </summary>
public abstract class Phoenicopterus : Phoenicopteridae, IPhoenicopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9216;

    /// <inheritdoc />
    public virtual string GenusName => "Phoenicopterus";

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
