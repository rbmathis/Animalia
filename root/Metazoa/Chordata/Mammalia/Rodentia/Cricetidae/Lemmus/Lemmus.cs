using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

/// <summary>
/// Abstract class for Lemmus (genus).
/// NCBI TaxId: 79948
/// </summary>
public abstract class Lemmus : Cricetidae, ILemmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lemmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79948;

    /// <inheritdoc />
    public virtual string GenusName => "Lemmus";

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
