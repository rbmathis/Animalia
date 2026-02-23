using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Thyropteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Thyropteridae.Thyroptera;

/// <summary>
/// Abstract class for Thyroptera (genus).
/// NCBI TaxId: 124758
/// </summary>
public abstract class Thyroptera : Thyropteridae, IThyroptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thyroptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 124758;

    /// <inheritdoc />
    public virtual string GenusName => "Thyroptera";

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
