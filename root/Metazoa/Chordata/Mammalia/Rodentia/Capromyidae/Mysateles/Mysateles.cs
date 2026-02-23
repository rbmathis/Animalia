using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Mysateles;

/// <summary>
/// Abstract class for Mysateles (genus).
/// NCBI TaxId: 1543404
/// </summary>
public abstract class Mysateles : Capromyidae, IMysateles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mysateles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543404;

    /// <inheritdoc />
    public virtual string GenusName => "Mysateles";

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
