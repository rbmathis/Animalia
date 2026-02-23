using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Alcichthys;

/// <summary>
/// Abstract class for Alcichthys (genus).
/// NCBI TaxId: 1508111
/// </summary>
public abstract class Alcichthys : Cottidae, IAlcichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1508111;

    /// <inheritdoc />
    public virtual string GenusName => "Alcichthys";

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
