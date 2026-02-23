using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Donacospiza;

/// <summary>
/// Abstract class for Donacospiza (genus).
/// NCBI TaxId: 555243
/// </summary>
public abstract class Donacospiza : Fringillidae, IDonacospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Donacospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555243;

    /// <inheritdoc />
    public virtual string GenusName => "Donacospiza";

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
