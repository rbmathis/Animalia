using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Salvator;

/// <summary>
/// Abstract class for Salvator (genus).
/// NCBI TaxId: 1469640
/// </summary>
public abstract class Salvator : Teiidae, ISalvator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salvator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1469640;

    /// <inheritdoc />
    public virtual string GenusName => "Salvator";

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
