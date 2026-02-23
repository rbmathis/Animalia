using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Phoenicurus;

/// <summary>
/// Abstract class for Phoenicurus (genus).
/// NCBI TaxId: 121422
/// </summary>
public abstract class Phoenicurus : Muscicapidae, IPhoenicurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121422;

    /// <inheritdoc />
    public virtual string GenusName => "Phoenicurus";

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
