using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Viridonia;

/// <summary>
/// Abstract class for Viridonia (genus).
/// NCBI TaxId: 3036910
/// </summary>
public abstract class Viridonia : Fringillidae, IViridonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Viridonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036910;

    /// <inheritdoc />
    public virtual string GenusName => "Viridonia";

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
