using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidodon;

/// <summary>
/// Abstract class for Scelidodon (genus).
/// NCBI TaxId: 2546655
/// </summary>
public abstract class Scelidodon : Mylodontidae, IScelidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scelidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546655;

    /// <inheritdoc />
    public virtual string GenusName => "Scelidodon";

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
