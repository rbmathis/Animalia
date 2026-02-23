using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lenoxus;

/// <summary>
/// Abstract class for Lenoxus (genus).
/// NCBI TaxId: 29114
/// </summary>
public abstract class Lenoxus : Cricetidae, ILenoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lenoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29114;

    /// <inheritdoc />
    public virtual string GenusName => "Lenoxus";

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
