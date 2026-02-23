using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Dracaena;

/// <summary>
/// Abstract class for Dracaena (genus).
/// NCBI TaxId: 420544
/// </summary>
public abstract class Dracaena : Teiidae, IDracaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dracaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420544;

    /// <inheritdoc />
    public virtual string GenusName => "Dracaena";

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
