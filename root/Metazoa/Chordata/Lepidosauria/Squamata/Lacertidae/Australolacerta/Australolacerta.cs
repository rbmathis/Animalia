using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Australolacerta;

/// <summary>
/// Abstract class for Australolacerta (genus).
/// NCBI TaxId: 410867
/// </summary>
public abstract class Australolacerta : Lacertidae, IAustralolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Australolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 410867;

    /// <inheritdoc />
    public virtual string GenusName => "Australolacerta";

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
