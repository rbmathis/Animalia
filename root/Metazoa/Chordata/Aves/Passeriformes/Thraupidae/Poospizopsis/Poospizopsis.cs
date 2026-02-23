using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Poospizopsis;

/// <summary>
/// Abstract class for Poospizopsis (genus).
/// NCBI TaxId: 3150847
/// </summary>
public abstract class Poospizopsis : Thraupidae, IPoospizopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poospizopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150847;

    /// <inheritdoc />
    public virtual string GenusName => "Poospizopsis";

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
