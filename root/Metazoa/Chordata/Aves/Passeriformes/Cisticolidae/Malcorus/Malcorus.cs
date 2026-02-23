using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Malcorus;

/// <summary>
/// Abstract class for Malcorus (genus).
/// NCBI TaxId: 1306882
/// </summary>
public abstract class Malcorus : Cisticolidae, IMalcorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malcorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306882;

    /// <inheritdoc />
    public virtual string GenusName => "Malcorus";

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
