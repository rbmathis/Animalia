using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Feroculus;

/// <summary>
/// Abstract class for Feroculus (genus).
/// NCBI TaxId: 1174663
/// </summary>
public abstract class Feroculus : Soricidae, IFeroculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feroculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1174663;

    /// <inheritdoc />
    public virtual string GenusName => "Feroculus";

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
