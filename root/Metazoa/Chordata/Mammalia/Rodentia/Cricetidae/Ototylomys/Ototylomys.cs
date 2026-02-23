using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ototylomys;

/// <summary>
/// Abstract class for Ototylomys (genus).
/// NCBI TaxId: 143266
/// </summary>
public abstract class Ototylomys : Cricetidae, IOtotylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ototylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143266;

    /// <inheritdoc />
    public virtual string GenusName => "Ototylomys";

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
