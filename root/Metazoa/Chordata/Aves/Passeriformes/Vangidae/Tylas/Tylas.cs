using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Tylas;

/// <summary>
/// Abstract class for Tylas (genus).
/// NCBI TaxId: 125310
/// </summary>
public abstract class Tylas : Vangidae, ITylas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125310;

    /// <inheritdoc />
    public virtual string GenusName => "Tylas";

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
