using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Pedetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Pedetidae.Pedetes;

/// <summary>
/// Abstract class for Pedetes (genus).
/// NCBI TaxId: 10022
/// </summary>
public abstract class Pedetes : Pedetidae, IPedetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pedetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10022;

    /// <inheritdoc />
    public virtual string GenusName => "Pedetes";

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
