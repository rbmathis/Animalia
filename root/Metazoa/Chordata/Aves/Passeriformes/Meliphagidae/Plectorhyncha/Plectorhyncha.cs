using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Plectorhyncha;

/// <summary>
/// Abstract class for Plectorhyncha (genus).
/// NCBI TaxId: 266370
/// </summary>
public abstract class Plectorhyncha : Meliphagidae, IPlectorhyncha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectorhyncha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266370;

    /// <inheritdoc />
    public virtual string GenusName => "Plectorhyncha";

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
