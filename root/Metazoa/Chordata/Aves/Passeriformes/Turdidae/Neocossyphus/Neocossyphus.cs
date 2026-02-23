using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Neocossyphus;

/// <summary>
/// Abstract class for Neocossyphus (genus).
/// NCBI TaxId: 127933
/// </summary>
public abstract class Neocossyphus : Turdidae, INeocossyphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocossyphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127933;

    /// <inheritdoc />
    public virtual string GenusName => "Neocossyphus";

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
