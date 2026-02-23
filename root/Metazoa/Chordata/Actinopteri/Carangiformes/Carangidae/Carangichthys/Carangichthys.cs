using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Carangichthys;

/// <summary>
/// Abstract class for Carangichthys (genus).
/// NCBI TaxId: 3049889
/// </summary>
public abstract class Carangichthys : Carangidae, ICarangichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carangichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049889;

    /// <inheritdoc />
    public virtual string GenusName => "Carangichthys";

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
