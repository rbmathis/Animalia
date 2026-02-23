using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Paranotothenia;

/// <summary>
/// Abstract class for Paranotothenia (genus).
/// NCBI TaxId: 37004
/// </summary>
public abstract class Paranotothenia : Nototheniidae, IParanotothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranotothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37004;

    /// <inheritdoc />
    public virtual string GenusName => "Paranotothenia";

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
