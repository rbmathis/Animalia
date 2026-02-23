using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Mulleripicus;

/// <summary>
/// Abstract class for Mulleripicus (genus).
/// NCBI TaxId: 315374
/// </summary>
public abstract class Mulleripicus : Picidae, IMulleripicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mulleripicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315374;

    /// <inheritdoc />
    public virtual string GenusName => "Mulleripicus";

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
