using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Cophixalus;

/// <summary>
/// Abstract class for Cophixalus (genus).
/// NCBI TaxId: 306589
/// </summary>
public abstract class Cophixalus : Microhylidae, ICophixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cophixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 306589;

    /// <inheritdoc />
    public virtual string GenusName => "Cophixalus";

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
