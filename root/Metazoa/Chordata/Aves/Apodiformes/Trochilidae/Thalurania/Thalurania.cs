using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Thalurania;

/// <summary>
/// Abstract class for Thalurania (genus).
/// NCBI TaxId: 190701
/// </summary>
public abstract class Thalurania : Trochilidae, IThalurania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalurania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190701;

    /// <inheritdoc />
    public virtual string GenusName => "Thalurania";

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
