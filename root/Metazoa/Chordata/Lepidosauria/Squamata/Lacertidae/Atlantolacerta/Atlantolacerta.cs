using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Atlantolacerta;

/// <summary>
/// Abstract class for Atlantolacerta (genus).
/// NCBI TaxId: 651307
/// </summary>
public abstract class Atlantolacerta : Lacertidae, IAtlantolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651307;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantolacerta";

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
