using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Ebinania;

/// <summary>
/// Abstract class for Ebinania (genus).
/// NCBI TaxId: 497218
/// </summary>
public abstract class Ebinania : Psychrolutidae, IEbinania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ebinania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497218;

    /// <inheritdoc />
    public virtual string GenusName => "Ebinania";

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
