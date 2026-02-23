using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Papurana;

/// <summary>
/// Abstract class for Papurana (genus).
/// NCBI TaxId: 1659746
/// </summary>
public abstract class Papurana : Ranidae, IPapurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659746;

    /// <inheritdoc />
    public virtual string GenusName => "Papurana";

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
