using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Pagothenia;

/// <summary>
/// Abstract class for Pagothenia (genus).
/// NCBI TaxId: 8211
/// </summary>
public abstract class Pagothenia : Nototheniidae, IPagothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8211;

    /// <inheritdoc />
    public virtual string GenusName => "Pagothenia";

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
