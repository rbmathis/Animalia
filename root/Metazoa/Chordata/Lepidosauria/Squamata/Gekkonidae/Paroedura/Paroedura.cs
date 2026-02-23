using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Paroedura;

/// <summary>
/// Abstract class for Paroedura (genus).
/// NCBI TaxId: 143629
/// </summary>
public abstract class Paroedura : Gekkonidae, IParoedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paroedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143629;

    /// <inheritdoc />
    public virtual string GenusName => "Paroedura";

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
