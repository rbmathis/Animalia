using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ramanella;

/// <summary>
/// Abstract class for Ramanella (genus).
/// NCBI TaxId: 143667
/// </summary>
public abstract class Ramanella : Microhylidae, IRamanella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramanella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143667;

    /// <inheritdoc />
    public virtual string GenusName => "Ramanella";

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
