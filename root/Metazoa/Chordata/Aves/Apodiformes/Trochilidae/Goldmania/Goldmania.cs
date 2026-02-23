using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Goldmania;

/// <summary>
/// Abstract class for Goldmania (genus).
/// NCBI TaxId: 1507463
/// </summary>
public abstract class Goldmania : Trochilidae, IGoldmania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goldmania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1507463;

    /// <inheritdoc />
    public virtual string GenusName => "Goldmania";

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
