using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Purnella;

/// <summary>
/// Abstract class for Purnella (genus).
/// NCBI TaxId: 1921818
/// </summary>
public abstract class Purnella : Meliphagidae, IPurnella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Purnella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1921818;

    /// <inheritdoc />
    public virtual string GenusName => "Purnella";

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
