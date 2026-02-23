using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Histrionicus;

/// <summary>
/// Abstract class for Histrionicus (genus).
/// NCBI TaxId: 68164
/// </summary>
public abstract class Histrionicus : Anatidae, IHistrionicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histrionicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68164;

    /// <inheritdoc />
    public virtual string GenusName => "Histrionicus";

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
