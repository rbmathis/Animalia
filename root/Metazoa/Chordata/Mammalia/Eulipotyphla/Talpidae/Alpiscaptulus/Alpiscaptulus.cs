using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Alpiscaptulus;

/// <summary>
/// Abstract class for Alpiscaptulus (genus).
/// NCBI TaxId: 2917337
/// </summary>
public abstract class Alpiscaptulus : Talpidae, IAlpiscaptulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alpiscaptulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2917337;

    /// <inheritdoc />
    public virtual string GenusName => "Alpiscaptulus";

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
