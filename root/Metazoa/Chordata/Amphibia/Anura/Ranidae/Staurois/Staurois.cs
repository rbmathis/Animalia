using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Staurois;

/// <summary>
/// Abstract class for Staurois (genus).
/// NCBI TaxId: 240405
/// </summary>
public abstract class Staurois : Ranidae, IStaurois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Staurois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240405;

    /// <inheritdoc />
    public virtual string GenusName => "Staurois";

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
