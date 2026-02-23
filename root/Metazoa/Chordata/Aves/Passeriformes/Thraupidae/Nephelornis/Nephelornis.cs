using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nephelornis;

/// <summary>
/// Abstract class for Nephelornis (genus).
/// NCBI TaxId: 62227
/// </summary>
public abstract class Nephelornis : Thraupidae, INephelornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nephelornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62227;

    /// <inheritdoc />
    public virtual string GenusName => "Nephelornis";

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
