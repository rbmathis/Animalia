using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Congolacerta;

/// <summary>
/// Abstract class for Congolacerta (genus).
/// NCBI TaxId: 1331293
/// </summary>
public abstract class Congolacerta : Lacertidae, ICongolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331293;

    /// <inheritdoc />
    public virtual string GenusName => "Congolacerta";

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
