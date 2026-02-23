using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Archaeolacerta;

/// <summary>
/// Abstract class for Archaeolacerta (genus).
/// NCBI TaxId: 178813
/// </summary>
public abstract class Archaeolacerta : Lacertidae, IArchaeolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archaeolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 178813;

    /// <inheritdoc />
    public virtual string GenusName => "Archaeolacerta";

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
