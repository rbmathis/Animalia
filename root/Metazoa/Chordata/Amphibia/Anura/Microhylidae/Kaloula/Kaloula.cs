using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kaloula;

/// <summary>
/// Abstract class for Kaloula (genus).
/// NCBI TaxId: 113379
/// </summary>
public abstract class Kaloula : Microhylidae, IKaloula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaloula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113379;

    /// <inheritdoc />
    public virtual string GenusName => "Kaloula";

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
