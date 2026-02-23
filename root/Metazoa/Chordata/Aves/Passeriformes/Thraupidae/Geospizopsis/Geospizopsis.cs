using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Geospizopsis;

/// <summary>
/// Abstract class for Geospizopsis (genus).
/// NCBI TaxId: 2691114
/// </summary>
public abstract class Geospizopsis : Thraupidae, IGeospizopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geospizopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2691114;

    /// <inheritdoc />
    public virtual string GenusName => "Geospizopsis";

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
