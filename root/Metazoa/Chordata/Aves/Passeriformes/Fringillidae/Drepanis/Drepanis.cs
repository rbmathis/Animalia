using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Drepanis;

/// <summary>
/// Abstract class for Drepanis (genus).
/// NCBI TaxId: 3036778
/// </summary>
public abstract class Drepanis : Fringillidae, IDrepanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drepanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036778;

    /// <inheritdoc />
    public virtual string GenusName => "Drepanis";

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
