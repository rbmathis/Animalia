using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Phrynella;

/// <summary>
/// Abstract class for Phrynella (genus).
/// NCBI TaxId: 980593
/// </summary>
public abstract class Phrynella : Microhylidae, IPhrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980593;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynella";

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
