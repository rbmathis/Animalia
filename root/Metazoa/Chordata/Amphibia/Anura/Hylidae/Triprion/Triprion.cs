using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Triprion;

/// <summary>
/// Abstract class for Triprion (genus).
/// NCBI TaxId: 317402
/// </summary>
public abstract class Triprion : Hylidae, ITriprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317402;

    /// <inheritdoc />
    public virtual string GenusName => "Triprion";

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
