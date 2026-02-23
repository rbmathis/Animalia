using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Haplophaedia;

/// <summary>
/// Abstract class for Haplophaedia (genus).
/// NCBI TaxId: 304641
/// </summary>
public abstract class Haplophaedia : Trochilidae, IHaplophaedia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplophaedia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304641;

    /// <inheritdoc />
    public virtual string GenusName => "Haplophaedia";

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
