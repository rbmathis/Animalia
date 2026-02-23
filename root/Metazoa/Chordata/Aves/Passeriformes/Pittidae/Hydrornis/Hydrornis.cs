using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Hydrornis;

/// <summary>
/// Abstract class for Hydrornis (genus).
/// NCBI TaxId: 1316416
/// </summary>
public abstract class Hydrornis : Pittidae, IHydrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1316416;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrornis";

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
