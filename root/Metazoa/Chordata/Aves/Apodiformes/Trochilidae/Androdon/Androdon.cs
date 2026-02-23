using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Androdon;

/// <summary>
/// Abstract class for Androdon (genus).
/// NCBI TaxId: 214660
/// </summary>
public abstract class Androdon : Trochilidae, IAndrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Androdon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214660;

    /// <inheritdoc />
    public virtual string GenusName => "Androdon";

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
