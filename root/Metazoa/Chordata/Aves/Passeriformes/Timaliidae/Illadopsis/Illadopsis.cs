using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Illadopsis;

/// <summary>
/// Abstract class for Illadopsis (genus).
/// NCBI TaxId: 98130
/// </summary>
public abstract class Illadopsis : Timaliidae, IIlladopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Illadopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98130;

    /// <inheritdoc />
    public virtual string GenusName => "Illadopsis";

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
