using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eurylepis;

/// <summary>
/// Abstract class for Eurylepis (genus).
/// NCBI TaxId: 273652
/// </summary>
public abstract class Eurylepis : Scincidae, IEurylepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurylepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 273652;

    /// <inheritdoc />
    public virtual string GenusName => "Eurylepis";

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
