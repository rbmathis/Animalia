using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Buccanodon;

/// <summary>
/// Abstract class for Buccanodon (genus).
/// NCBI TaxId: 240731
/// </summary>
public abstract class Buccanodon : Lybiidae, IBuccanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buccanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240731;

    /// <inheritdoc />
    public virtual string GenusName => "Buccanodon";

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
