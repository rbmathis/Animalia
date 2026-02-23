using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Heinrichia;

/// <summary>
/// Abstract class for Heinrichia (genus).
/// NCBI TaxId: 758442
/// </summary>
public abstract class Heinrichia : Turdidae, IHeinrichia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heinrichia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758442;

    /// <inheritdoc />
    public virtual string GenusName => "Heinrichia";

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
