using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Bradypterus;

/// <summary>
/// Abstract class for Bradypterus (genus).
/// NCBI TaxId: 203786
/// </summary>
public abstract class Bradypterus : Locustellidae, IBradypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bradypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203786;

    /// <inheritdoc />
    public virtual string GenusName => "Bradypterus";

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
