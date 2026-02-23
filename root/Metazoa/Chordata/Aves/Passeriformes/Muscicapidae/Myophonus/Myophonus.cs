using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Myophonus;

/// <summary>
/// Abstract class for Myophonus (genus).
/// NCBI TaxId: 869932
/// </summary>
public abstract class Myophonus : Muscicapidae, IMyophonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myophonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 869932;

    /// <inheritdoc />
    public virtual string GenusName => "Myophonus";

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
