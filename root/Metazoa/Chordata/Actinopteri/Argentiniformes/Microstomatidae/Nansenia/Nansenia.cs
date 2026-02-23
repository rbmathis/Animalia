using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae.Nansenia;

/// <summary>
/// Abstract class for Nansenia (genus).
/// NCBI TaxId: 170198
/// </summary>
public abstract class Nansenia : Microstomatidae, INansenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nansenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170198;

    /// <inheritdoc />
    public virtual string GenusName => "Nansenia";

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
