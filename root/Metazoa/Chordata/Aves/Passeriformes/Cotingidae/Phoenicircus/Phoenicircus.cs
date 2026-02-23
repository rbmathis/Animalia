using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Phoenicircus;

/// <summary>
/// Abstract class for Phoenicircus (genus).
/// NCBI TaxId: 114337
/// </summary>
public abstract class Phoenicircus : Cotingidae, IPhoenicircus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicircus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114337;

    /// <inheritdoc />
    public virtual string GenusName => "Phoenicircus";

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
