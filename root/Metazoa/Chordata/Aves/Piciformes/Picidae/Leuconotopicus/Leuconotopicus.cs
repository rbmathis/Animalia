using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Leuconotopicus;

/// <summary>
/// Abstract class for Leuconotopicus (genus).
/// NCBI TaxId: 2821868
/// </summary>
public abstract class Leuconotopicus : Picidae, ILeuconotopicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leuconotopicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821868;

    /// <inheritdoc />
    public virtual string GenusName => "Leuconotopicus";

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
