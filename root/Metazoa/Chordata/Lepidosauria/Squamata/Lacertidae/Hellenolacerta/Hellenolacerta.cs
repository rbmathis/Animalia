using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Hellenolacerta;

/// <summary>
/// Abstract class for Hellenolacerta (genus).
/// NCBI TaxId: 651317
/// </summary>
public abstract class Hellenolacerta : Lacertidae, IHellenolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hellenolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651317;

    /// <inheritdoc />
    public virtual string GenusName => "Hellenolacerta";

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
