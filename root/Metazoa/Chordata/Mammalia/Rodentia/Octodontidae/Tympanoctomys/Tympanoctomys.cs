using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Tympanoctomys;

/// <summary>
/// Abstract class for Tympanoctomys (genus).
/// NCBI TaxId: 61881
/// </summary>
public abstract class Tympanoctomys : Octodontidae, ITympanoctomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tympanoctomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61881;

    /// <inheritdoc />
    public virtual string GenusName => "Tympanoctomys";

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
