using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Streptoprocne;

/// <summary>
/// Abstract class for Streptoprocne (genus).
/// NCBI TaxId: 46504
/// </summary>
public abstract class Streptoprocne : Apodidae, IStreptoprocne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Streptoprocne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46504;

    /// <inheritdoc />
    public virtual string GenusName => "Streptoprocne";

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
