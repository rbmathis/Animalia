using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Microchirus;

/// <summary>
/// Abstract class for Microchirus (genus).
/// NCBI TaxId: 90072
/// </summary>
public abstract class Microchirus : Soleidae, IMicrochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microchirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90072;

    /// <inheritdoc />
    public virtual string GenusName => "Microchirus";

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
