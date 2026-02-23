using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Ramphodon;

/// <summary>
/// Abstract class for Ramphodon (genus).
/// NCBI TaxId: 214668
/// </summary>
public abstract class Ramphodon : Trochilidae, IRamphodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214668;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphodon";

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
