using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Iranolacerta;

/// <summary>
/// Abstract class for Iranolacerta (genus).
/// NCBI TaxId: 651319
/// </summary>
public abstract class Iranolacerta : Lacertidae, IIranolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iranolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651319;

    /// <inheritdoc />
    public virtual string GenusName => "Iranolacerta";

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
