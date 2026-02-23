using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Sauromalus;

/// <summary>
/// Abstract class for Sauromalus (genus).
/// NCBI TaxId: 51218
/// </summary>
public abstract class Sauromalus : Iguanidae, ISauromalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sauromalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51218;

    /// <inheritdoc />
    public virtual string GenusName => "Sauromalus";

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
