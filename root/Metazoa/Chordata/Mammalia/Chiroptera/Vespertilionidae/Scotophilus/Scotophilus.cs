using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotophilus;

/// <summary>
/// Abstract class for Scotophilus (genus).
/// NCBI TaxId: 153296
/// </summary>
public abstract class Scotophilus : Vespertilionidae, IScotophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153296;

    /// <inheritdoc />
    public virtual string GenusName => "Scotophilus";

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
