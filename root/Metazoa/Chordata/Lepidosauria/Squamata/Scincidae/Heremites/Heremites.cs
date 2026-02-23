using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Heremites;

/// <summary>
/// Abstract class for Heremites (genus).
/// NCBI TaxId: 1860160
/// </summary>
public abstract class Heremites : Scincidae, IHeremites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heremites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1860160;

    /// <inheritdoc />
    public virtual string GenusName => "Heremites";

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
