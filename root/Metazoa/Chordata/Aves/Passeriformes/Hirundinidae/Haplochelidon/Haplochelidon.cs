using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Haplochelidon;

/// <summary>
/// Abstract class for Haplochelidon (genus).
/// NCBI TaxId: 317108
/// </summary>
public abstract class Haplochelidon : Hirundinidae, IHaplochelidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplochelidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317108;

    /// <inheritdoc />
    public virtual string GenusName => "Haplochelidon";

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
