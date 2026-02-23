using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Spindalis;

/// <summary>
/// Abstract class for Spindalis (genus).
/// NCBI TaxId: 62247
/// </summary>
public abstract class Spindalis : Thraupidae, ISpindalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spindalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62247;

    /// <inheritdoc />
    public virtual string GenusName => "Spindalis";

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
