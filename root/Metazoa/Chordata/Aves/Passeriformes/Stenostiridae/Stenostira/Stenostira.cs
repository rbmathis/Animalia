using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Stenostira;

/// <summary>
/// Abstract class for Stenostira (genus).
/// NCBI TaxId: 315552
/// </summary>
public abstract class Stenostira : Stenostiridae, IStenostira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenostira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315552;

    /// <inheritdoc />
    public virtual string GenusName => "Stenostira";

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
