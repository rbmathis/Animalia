using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Janetaescincus;

/// <summary>
/// Abstract class for Janetaescincus (genus).
/// NCBI TaxId: 293413
/// </summary>
public abstract class Janetaescincus : Scincidae, IJanetaescincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Janetaescincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293413;

    /// <inheritdoc />
    public virtual string GenusName => "Janetaescincus";

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
