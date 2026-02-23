using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Lycocorax;

/// <summary>
/// Abstract class for Lycocorax (genus).
/// NCBI TaxId: 681191
/// </summary>
public abstract class Lycocorax : Paradisaeidae, ILycocorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycocorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681191;

    /// <inheritdoc />
    public virtual string GenusName => "Lycocorax";

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
