using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Phoenicolacerta;

/// <summary>
/// Abstract class for Phoenicolacerta (genus).
/// NCBI TaxId: 575495
/// </summary>
public abstract class Phoenicolacerta : Lacertidae, IPhoenicolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 575495;

    /// <inheritdoc />
    public virtual string GenusName => "Phoenicolacerta";

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
