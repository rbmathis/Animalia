using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Bryozoichthys;

/// <summary>
/// Abstract class for Bryozoichthys (genus).
/// NCBI TaxId: 1311537
/// </summary>
public abstract class Bryozoichthys : Stichaeidae, IBryozoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryozoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311537;

    /// <inheritdoc />
    public virtual string GenusName => "Bryozoichthys";

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
