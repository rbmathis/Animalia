using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Zeledonia;

/// <summary>
/// Abstract class for Zeledonia (genus).
/// NCBI TaxId: 182954
/// </summary>
public abstract class Zeledonia : Parulidae, IZeledonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zeledonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182954;

    /// <inheritdoc />
    public virtual string GenusName => "Zeledonia";

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
