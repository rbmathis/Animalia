using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metaphrynella;

/// <summary>
/// Abstract class for Metaphrynella (genus).
/// NCBI TaxId: 419660
/// </summary>
public abstract class Metaphrynella : Microhylidae, IMetaphrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metaphrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419660;

    /// <inheritdoc />
    public virtual string GenusName => "Metaphrynella";

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
