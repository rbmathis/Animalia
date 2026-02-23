using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Apathya;

/// <summary>
/// Abstract class for Apathya (genus).
/// NCBI TaxId: 651313
/// </summary>
public abstract class Apathya : Lacertidae, IApathya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apathya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651313;

    /// <inheritdoc />
    public virtual string GenusName => "Apathya";

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
