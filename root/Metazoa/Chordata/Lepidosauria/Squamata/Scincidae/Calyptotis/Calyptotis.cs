using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Calyptotis;

/// <summary>
/// Abstract class for Calyptotis (genus).
/// NCBI TaxId: 172935
/// </summary>
public abstract class Calyptotis : Scincidae, ICalyptotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172935;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptotis";

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
