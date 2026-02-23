using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Glycichaera;

/// <summary>
/// Abstract class for Glycichaera (genus).
/// NCBI TaxId: 266357
/// </summary>
public abstract class Glycichaera : Meliphagidae, IGlycichaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glycichaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266357;

    /// <inheritdoc />
    public virtual string GenusName => "Glycichaera";

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
