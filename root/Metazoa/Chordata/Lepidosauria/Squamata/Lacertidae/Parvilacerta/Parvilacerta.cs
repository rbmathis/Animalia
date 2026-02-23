using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Parvilacerta;

/// <summary>
/// Abstract class for Parvilacerta (genus).
/// NCBI TaxId: 428142
/// </summary>
public abstract class Parvilacerta : Lacertidae, IParvilacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvilacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428142;

    /// <inheritdoc />
    public virtual string GenusName => "Parvilacerta";

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
