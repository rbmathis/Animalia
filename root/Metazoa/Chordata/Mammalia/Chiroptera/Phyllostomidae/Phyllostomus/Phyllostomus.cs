using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllostomus;

/// <summary>
/// Abstract class for Phyllostomus (genus).
/// NCBI TaxId: 9422
/// </summary>
public abstract class Phyllostomus : Phyllostomidae, IPhyllostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9422;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllostomus";

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
