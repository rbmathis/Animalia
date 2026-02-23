using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Mydaus;

/// <summary>
/// Abstract class for Mydaus (genus).
/// NCBI TaxId: 55044
/// </summary>
public abstract class Mydaus : Mephitidae, IMydaus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mydaus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55044;

    /// <inheritdoc />
    public virtual string GenusName => "Mydaus";

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
