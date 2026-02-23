using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Rhampholeon;

/// <summary>
/// Abstract class for Rhampholeon (genus).
/// NCBI TaxId: 91911
/// </summary>
public abstract class Rhampholeon : Chamaeleonidae, IRhampholeon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhampholeon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91911;

    /// <inheritdoc />
    public virtual string GenusName => "Rhampholeon";

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
