using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Yungipicus;

/// <summary>
/// Abstract class for Yungipicus (genus).
/// NCBI TaxId: 2823210
/// </summary>
public abstract class Yungipicus : Picidae, IYungipicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yungipicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823210;

    /// <inheritdoc />
    public virtual string GenusName => "Yungipicus";

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
