using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Indonotothenia;

/// <summary>
/// Abstract class for Indonotothenia (genus).
/// NCBI TaxId: 101501
/// </summary>
public abstract class Indonotothenia : Nototheniidae, IIndonotothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indonotothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101501;

    /// <inheritdoc />
    public virtual string GenusName => "Indonotothenia";

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
