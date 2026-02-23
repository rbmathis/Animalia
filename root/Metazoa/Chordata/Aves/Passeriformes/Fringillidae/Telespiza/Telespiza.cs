using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Telespiza;

/// <summary>
/// Abstract class for Telespiza (genus).
/// NCBI TaxId: 74862
/// </summary>
public abstract class Telespiza : Fringillidae, ITelespiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telespiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74862;

    /// <inheritdoc />
    public virtual string GenusName => "Telespiza";

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
