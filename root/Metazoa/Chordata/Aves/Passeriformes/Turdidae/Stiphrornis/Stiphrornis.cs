using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Stiphrornis;

/// <summary>
/// Abstract class for Stiphrornis (genus).
/// NCBI TaxId: 94611
/// </summary>
public abstract class Stiphrornis : Turdidae, IStiphrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stiphrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94611;

    /// <inheritdoc />
    public virtual string GenusName => "Stiphrornis";

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
