using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Bangsia;

/// <summary>
/// Abstract class for Bangsia (genus).
/// NCBI TaxId: 548497
/// </summary>
public abstract class Bangsia : Thraupidae, IBangsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bangsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548497;

    /// <inheritdoc />
    public virtual string GenusName => "Bangsia";

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
