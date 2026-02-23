using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Mayrornis;

/// <summary>
/// Abstract class for Mayrornis (genus).
/// NCBI TaxId: 338451
/// </summary>
public abstract class Mayrornis : Monarchidae, IMayrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mayrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338451;

    /// <inheritdoc />
    public virtual string GenusName => "Mayrornis";

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
