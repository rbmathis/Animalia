using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Pardofelis;

/// <summary>
/// Abstract class for Pardofelis (genus).
/// NCBI TaxId: 61409
/// </summary>
public abstract class Pardofelis : Felidae, IPardofelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pardofelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61409;

    /// <inheritdoc />
    public virtual string GenusName => "Pardofelis";

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
