using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Anatololacerta;

/// <summary>
/// Abstract class for Anatololacerta (genus).
/// NCBI TaxId: 651309
/// </summary>
public abstract class Anatololacerta : Lacertidae, IAnatololacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anatololacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651309;

    /// <inheritdoc />
    public virtual string GenusName => "Anatololacerta";

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
