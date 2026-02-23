using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Microchera;

/// <summary>
/// Abstract class for Microchera (genus).
/// NCBI TaxId: 472894
/// </summary>
public abstract class Microchera : Trochilidae, IMicrochera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microchera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472894;

    /// <inheritdoc />
    public virtual string GenusName => "Microchera";

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
