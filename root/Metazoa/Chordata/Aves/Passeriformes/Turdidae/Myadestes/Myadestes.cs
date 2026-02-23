using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Myadestes;

/// <summary>
/// Abstract class for Myadestes (genus).
/// NCBI TaxId: 123380
/// </summary>
public abstract class Myadestes : Turdidae, IMyadestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myadestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123380;

    /// <inheritdoc />
    public virtual string GenusName => "Myadestes";

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
