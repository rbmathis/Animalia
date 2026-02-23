using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Heteronotia;

/// <summary>
/// Abstract class for Heteronotia (genus).
/// NCBI TaxId: 13084
/// </summary>
public abstract class Heteronotia : Gekkonidae, IHeteronotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteronotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13084;

    /// <inheritdoc />
    public virtual string GenusName => "Heteronotia";

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
