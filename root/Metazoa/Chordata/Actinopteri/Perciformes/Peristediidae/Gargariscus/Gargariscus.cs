using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Gargariscus;

/// <summary>
/// Abstract class for Gargariscus (genus).
/// NCBI TaxId: 1188035
/// </summary>
public abstract class Gargariscus : Peristediidae, IGargariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gargariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1188035;

    /// <inheritdoc />
    public virtual string GenusName => "Gargariscus";

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
