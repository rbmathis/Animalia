using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Malpolon;

/// <summary>
/// Abstract class for Malpolon (genus).
/// NCBI TaxId: 184163
/// </summary>
public abstract class Malpolon : Lamprophiidae, IMalpolon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malpolon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184163;

    /// <inheritdoc />
    public virtual string GenusName => "Malpolon";

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
