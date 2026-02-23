using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Xiphidiopicus;

/// <summary>
/// Abstract class for Xiphidiopicus (genus).
/// NCBI TaxId: 177294
/// </summary>
public abstract class Xiphidiopicus : Picidae, IXiphidiopicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphidiopicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 177294;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphidiopicus";

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
