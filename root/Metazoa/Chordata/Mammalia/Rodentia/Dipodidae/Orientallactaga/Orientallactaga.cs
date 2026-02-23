using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Orientallactaga;

/// <summary>
/// Abstract class for Orientallactaga (genus).
/// NCBI TaxId: 2776189
/// </summary>
public abstract class Orientallactaga : Dipodidae, IOrientallactaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orientallactaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2776189;

    /// <inheritdoc />
    public virtual string GenusName => "Orientallactaga";

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
