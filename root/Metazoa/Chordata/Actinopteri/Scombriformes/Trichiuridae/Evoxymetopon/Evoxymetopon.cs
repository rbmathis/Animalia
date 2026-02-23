using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Evoxymetopon;

/// <summary>
/// Abstract class for Evoxymetopon (genus).
/// NCBI TaxId: 1183395
/// </summary>
public abstract class Evoxymetopon : Trichiuridae, IEvoxymetopon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evoxymetopon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183395;

    /// <inheritdoc />
    public virtual string GenusName => "Evoxymetopon";

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
