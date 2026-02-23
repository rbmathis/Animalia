using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Marisora;

/// <summary>
/// Abstract class for Marisora (genus).
/// NCBI TaxId: 1190694
/// </summary>
public abstract class Marisora : Scincidae, IMarisora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marisora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1190694;

    /// <inheritdoc />
    public virtual string GenusName => "Marisora";

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
