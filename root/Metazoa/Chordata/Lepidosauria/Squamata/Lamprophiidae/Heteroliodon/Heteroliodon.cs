using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Heteroliodon;

/// <summary>
/// Abstract class for Heteroliodon (genus).
/// NCBI TaxId: 224549
/// </summary>
public abstract class Heteroliodon : Lamprophiidae, IHeteroliodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroliodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224549;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroliodon";

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
