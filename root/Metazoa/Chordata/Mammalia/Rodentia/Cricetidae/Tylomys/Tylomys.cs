using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tylomys;

/// <summary>
/// Abstract class for Tylomys (genus).
/// NCBI TaxId: 164612
/// </summary>
public abstract class Tylomys : Cricetidae, ITylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164612;

    /// <inheritdoc />
    public virtual string GenusName => "Tylomys";

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
