using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Taenianotus;

/// <summary>
/// Abstract class for Taenianotus (genus).
/// NCBI TaxId: 274708
/// </summary>
public abstract class Taenianotus : Scorpaenidae, ITaenianotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taenianotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274708;

    /// <inheritdoc />
    public virtual string GenusName => "Taenianotus";

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
