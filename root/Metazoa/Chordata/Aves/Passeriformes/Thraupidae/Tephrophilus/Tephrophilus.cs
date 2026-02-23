using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Tephrophilus;

/// <summary>
/// Abstract class for Tephrophilus (genus).
/// NCBI TaxId: 3150852
/// </summary>
public abstract class Tephrophilus : Thraupidae, ITephrophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tephrophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150852;

    /// <inheritdoc />
    public virtual string GenusName => "Tephrophilus";

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
