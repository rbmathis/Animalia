using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Sirenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Sirenidae.Pseudobranchus;

/// <summary>
/// Abstract class for Pseudobranchus (genus).
/// NCBI TaxId: 294366
/// </summary>
public abstract class Pseudobranchus : Sirenidae, IPseudobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 294366;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobranchus";

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
