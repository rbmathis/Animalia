using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Vauriella;

/// <summary>
/// Abstract class for Vauriella (genus).
/// NCBI TaxId: 2823213
/// </summary>
public abstract class Vauriella : Muscicapidae, IVauriella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vauriella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823213;

    /// <inheritdoc />
    public virtual string GenusName => "Vauriella";

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
