using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Pherohapsis;

/// <summary>
/// Abstract class for Pherohapsis (genus).
/// NCBI TaxId: 1075808
/// </summary>
public abstract class Pherohapsis : Microhylidae, IPherohapsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pherohapsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1075808;

    /// <inheritdoc />
    public virtual string GenusName => "Pherohapsis";

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
