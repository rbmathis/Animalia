using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Satyrichthys;

/// <summary>
/// Abstract class for Satyrichthys (genus).
/// NCBI TaxId: 181454
/// </summary>
public abstract class Satyrichthys : Peristediidae, ISatyrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Satyrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181454;

    /// <inheritdoc />
    public virtual string GenusName => "Satyrichthys";

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
