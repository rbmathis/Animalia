using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Notothenia;

/// <summary>
/// Abstract class for Notothenia (genus).
/// NCBI TaxId: 8207
/// </summary>
public abstract class Notothenia : Nototheniidae, INotothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8207;

    /// <inheritdoc />
    public virtual string GenusName => "Notothenia";

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
