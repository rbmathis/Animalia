using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Transandinomys;

/// <summary>
/// Abstract class for Transandinomys (genus).
/// NCBI TaxId: 530182
/// </summary>
public abstract class Transandinomys : Cricetidae, ITransandinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Transandinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 530182;

    /// <inheritdoc />
    public virtual string GenusName => "Transandinomys";

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
