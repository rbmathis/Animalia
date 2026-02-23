using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Locustella;

/// <summary>
/// Abstract class for Locustella (genus).
/// NCBI TaxId: 68487
/// </summary>
public abstract class Locustella : Locustellidae, ILocustella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Locustella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68487;

    /// <inheritdoc />
    public virtual string GenusName => "Locustella";

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
