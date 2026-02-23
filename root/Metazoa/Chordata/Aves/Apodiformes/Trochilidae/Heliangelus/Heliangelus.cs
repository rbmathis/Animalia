using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliangelus;

/// <summary>
/// Abstract class for Heliangelus (genus).
/// NCBI TaxId: 66416
/// </summary>
public abstract class Heliangelus : Trochilidae, IHeliangelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliangelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66416;

    /// <inheritdoc />
    public virtual string GenusName => "Heliangelus";

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
