using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Grallina;

/// <summary>
/// Abstract class for Grallina (genus).
/// NCBI TaxId: 254540
/// </summary>
public abstract class Grallina : Monarchidae, IGrallina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grallina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254540;

    /// <inheritdoc />
    public virtual string GenusName => "Grallina";

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
