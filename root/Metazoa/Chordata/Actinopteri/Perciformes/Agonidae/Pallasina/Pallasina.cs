using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Pallasina;

/// <summary>
/// Abstract class for Pallasina (genus).
/// NCBI TaxId: 740931
/// </summary>
public abstract class Pallasina : Agonidae, IPallasina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pallasina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740931;

    /// <inheritdoc />
    public virtual string GenusName => "Pallasina";

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
