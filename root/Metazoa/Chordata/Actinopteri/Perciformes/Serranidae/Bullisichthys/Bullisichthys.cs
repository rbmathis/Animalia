using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Bullisichthys;

/// <summary>
/// Abstract class for Bullisichthys (genus).
/// NCBI TaxId: 2890331
/// </summary>
public abstract class Bullisichthys : Serranidae, IBullisichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bullisichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890331;

    /// <inheritdoc />
    public virtual string GenusName => "Bullisichthys";

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
