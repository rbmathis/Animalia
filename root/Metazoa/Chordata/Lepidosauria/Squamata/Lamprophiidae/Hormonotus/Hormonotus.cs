using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Hormonotus;

/// <summary>
/// Abstract class for Hormonotus (genus).
/// NCBI TaxId: 578136
/// </summary>
public abstract class Hormonotus : Lamprophiidae, IHormonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hormonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 578136;

    /// <inheritdoc />
    public virtual string GenusName => "Hormonotus";

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
