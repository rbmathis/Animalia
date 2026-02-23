using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Euphonia;

/// <summary>
/// Abstract class for Euphonia (genus).
/// NCBI TaxId: 62198
/// </summary>
public abstract class Euphonia : Fringillidae, IEuphonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euphonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62198;

    /// <inheritdoc />
    public virtual string GenusName => "Euphonia";

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
