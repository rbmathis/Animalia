using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metamagnusia;

/// <summary>
/// Abstract class for Metamagnusia (genus).
/// NCBI TaxId: 987047
/// </summary>
public abstract class Metamagnusia : Microhylidae, IMetamagnusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metamagnusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 987047;

    /// <inheritdoc />
    public virtual string GenusName => "Metamagnusia";

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
