using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

/// <summary>
/// Abstract class for Heteromys (genus).
/// NCBI TaxId: 101675
/// </summary>
public abstract class Heteromys : Heteromyidae, IHeteromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101675;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromys";

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
