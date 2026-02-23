using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotomanes;

/// <summary>
/// Abstract class for Scotomanes (genus).
/// NCBI TaxId: 258956
/// </summary>
public abstract class Scotomanes : Vespertilionidae, IScotomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258956;

    /// <inheritdoc />
    public virtual string GenusName => "Scotomanes";

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
