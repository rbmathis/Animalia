using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliomaster;

/// <summary>
/// Abstract class for Heliomaster (genus).
/// NCBI TaxId: 135171
/// </summary>
public abstract class Heliomaster : Trochilidae, IHeliomaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliomaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135171;

    /// <inheritdoc />
    public virtual string GenusName => "Heliomaster";

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
