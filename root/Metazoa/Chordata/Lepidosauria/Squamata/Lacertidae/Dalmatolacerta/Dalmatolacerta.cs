using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Dalmatolacerta;

/// <summary>
/// Abstract class for Dalmatolacerta (genus).
/// NCBI TaxId: 651315
/// </summary>
public abstract class Dalmatolacerta : Lacertidae, IDalmatolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dalmatolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651315;

    /// <inheritdoc />
    public virtual string GenusName => "Dalmatolacerta";

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
