using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Hemirhagerrhis;

/// <summary>
/// Abstract class for Hemirhagerrhis (genus).
/// NCBI TaxId: 234068
/// </summary>
public abstract class Hemirhagerrhis : Lamprophiidae, IHemirhagerrhis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemirhagerrhis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234068;

    /// <inheritdoc />
    public virtual string GenusName => "Hemirhagerrhis";

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
