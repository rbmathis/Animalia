using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eumeces;

/// <summary>
/// Abstract class for Eumeces (genus).
/// NCBI TaxId: 8528
/// </summary>
public abstract class Eumeces : Scincidae, IEumeces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumeces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8528;

    /// <inheritdoc />
    public virtual string GenusName => "Eumeces";

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
