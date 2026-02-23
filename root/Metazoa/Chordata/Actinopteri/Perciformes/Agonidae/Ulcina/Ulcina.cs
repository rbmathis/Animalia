using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Ulcina;

/// <summary>
/// Abstract class for Ulcina (genus).
/// NCBI TaxId: 980418
/// </summary>
public abstract class Ulcina : Agonidae, IUlcina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ulcina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980418;

    /// <inheritdoc />
    public virtual string GenusName => "Ulcina";

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
