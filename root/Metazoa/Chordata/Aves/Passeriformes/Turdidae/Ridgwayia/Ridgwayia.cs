using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Ridgwayia;

/// <summary>
/// Abstract class for Ridgwayia (genus).
/// NCBI TaxId: 2823196
/// </summary>
public abstract class Ridgwayia : Turdidae, IRidgwayia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ridgwayia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823196;

    /// <inheritdoc />
    public virtual string GenusName => "Ridgwayia";

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
