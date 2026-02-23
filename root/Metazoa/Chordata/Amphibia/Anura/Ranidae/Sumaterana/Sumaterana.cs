using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sumaterana;

/// <summary>
/// Abstract class for Sumaterana (genus).
/// NCBI TaxId: 2282210
/// </summary>
public abstract class Sumaterana : Ranidae, ISumaterana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sumaterana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2282210;

    /// <inheritdoc />
    public virtual string GenusName => "Sumaterana";

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
