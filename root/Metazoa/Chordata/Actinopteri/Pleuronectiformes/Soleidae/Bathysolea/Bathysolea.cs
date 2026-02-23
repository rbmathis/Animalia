using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Bathysolea;

/// <summary>
/// Abstract class for Bathysolea (genus).
/// NCBI TaxId: 253865
/// </summary>
public abstract class Bathysolea : Soleidae, IBathysolea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathysolea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 253865;

    /// <inheritdoc />
    public virtual string GenusName => "Bathysolea";

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
