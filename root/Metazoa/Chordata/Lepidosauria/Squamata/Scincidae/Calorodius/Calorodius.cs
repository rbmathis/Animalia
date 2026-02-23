using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Calorodius;

/// <summary>
/// Abstract class for Calorodius (genus).
/// NCBI TaxId: 3028230
/// </summary>
public abstract class Calorodius : Scincidae, ICalorodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calorodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3028230;

    /// <inheritdoc />
    public virtual string GenusName => "Calorodius";

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
