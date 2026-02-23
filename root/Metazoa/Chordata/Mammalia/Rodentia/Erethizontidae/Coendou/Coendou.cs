using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Abstract class for Coendou (genus).
/// NCBI TaxId: 43319
/// </summary>
public abstract class Coendou : Erethizontidae, ICoendou
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coendou";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43319;

    /// <inheritdoc />
    public virtual string GenusName => "Coendou";

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
