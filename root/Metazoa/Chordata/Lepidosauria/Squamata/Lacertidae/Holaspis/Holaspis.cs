using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Holaspis;

/// <summary>
/// Abstract class for Holaspis (genus).
/// NCBI TaxId: 450756
/// </summary>
public abstract class Holaspis : Lacertidae, IHolaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 450756;

    /// <inheritdoc />
    public virtual string GenusName => "Holaspis";

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
