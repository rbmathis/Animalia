using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Sephanoides;

/// <summary>
/// Abstract class for Sephanoides (genus).
/// NCBI TaxId: 56666
/// </summary>
public abstract class Sephanoides : Trochilidae, ISephanoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sephanoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56666;

    /// <inheritdoc />
    public virtual string GenusName => "Sephanoides";

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
