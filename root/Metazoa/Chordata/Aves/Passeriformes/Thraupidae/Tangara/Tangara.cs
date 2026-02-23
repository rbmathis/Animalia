using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Tangara;

/// <summary>
/// Abstract class for Tangara (genus).
/// NCBI TaxId: 58206
/// </summary>
public abstract class Tangara : Thraupidae, ITangara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tangara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58206;

    /// <inheritdoc />
    public virtual string GenusName => "Tangara";

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
