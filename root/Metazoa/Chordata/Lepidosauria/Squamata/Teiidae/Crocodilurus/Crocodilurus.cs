using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Crocodilurus;

/// <summary>
/// Abstract class for Crocodilurus (genus).
/// NCBI TaxId: 420542
/// </summary>
public abstract class Crocodilurus : Teiidae, ICrocodilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crocodilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420542;

    /// <inheritdoc />
    public virtual string GenusName => "Crocodilurus";

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
