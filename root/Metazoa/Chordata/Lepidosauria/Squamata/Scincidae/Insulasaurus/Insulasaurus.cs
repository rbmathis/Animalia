using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Insulasaurus;

/// <summary>
/// Abstract class for Insulasaurus (genus).
/// NCBI TaxId: 1351706
/// </summary>
public abstract class Insulasaurus : Scincidae, IInsulasaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Insulasaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1351706;

    /// <inheritdoc />
    public virtual string GenusName => "Insulasaurus";

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
