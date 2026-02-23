using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Macrotarsomys;

/// <summary>
/// Abstract class for Macrotarsomys (genus).
/// NCBI TaxId: 52802
/// </summary>
public abstract class Macrotarsomys : Nesomyidae, IMacrotarsomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrotarsomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52802;

    /// <inheritdoc />
    public virtual string GenusName => "Macrotarsomys";

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
