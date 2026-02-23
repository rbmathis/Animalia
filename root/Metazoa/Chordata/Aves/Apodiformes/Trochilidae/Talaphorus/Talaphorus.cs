using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Talaphorus;

/// <summary>
/// Abstract class for Talaphorus (genus).
/// NCBI TaxId: 2954069
/// </summary>
public abstract class Talaphorus : Trochilidae, ITalaphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Talaphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954069;

    /// <inheritdoc />
    public virtual string GenusName => "Talaphorus";

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
