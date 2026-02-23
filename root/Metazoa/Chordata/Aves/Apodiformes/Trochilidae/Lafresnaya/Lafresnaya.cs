using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lafresnaya;

/// <summary>
/// Abstract class for Lafresnaya (genus).
/// NCBI TaxId: 56654
/// </summary>
public abstract class Lafresnaya : Trochilidae, ILafresnaya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lafresnaya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56654;

    /// <inheritdoc />
    public virtual string GenusName => "Lafresnaya";

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
