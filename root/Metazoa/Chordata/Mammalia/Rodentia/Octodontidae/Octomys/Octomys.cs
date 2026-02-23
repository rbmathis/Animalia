using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octomys;

/// <summary>
/// Abstract class for Octomys (genus).
/// NCBI TaxId: 135582
/// </summary>
public abstract class Octomys : Octodontidae, IOctomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Octomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135582;

    /// <inheritdoc />
    public virtual string GenusName => "Octomys";

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
