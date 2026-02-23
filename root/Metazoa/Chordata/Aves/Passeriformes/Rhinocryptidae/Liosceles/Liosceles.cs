using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Liosceles;

/// <summary>
/// Abstract class for Liosceles (genus).
/// NCBI TaxId: 255376
/// </summary>
public abstract class Liosceles : Rhinocryptidae, ILiosceles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liosceles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255376;

    /// <inheritdoc />
    public virtual string GenusName => "Liosceles";

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
