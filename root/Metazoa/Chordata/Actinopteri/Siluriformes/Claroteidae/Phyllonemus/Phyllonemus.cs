using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Phyllonemus;

/// <summary>
/// Abstract class for Phyllonemus (genus).
/// NCBI TaxId: 390421
/// </summary>
public abstract class Phyllonemus : Claroteidae, IPhyllonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390421;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllonemus";

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
