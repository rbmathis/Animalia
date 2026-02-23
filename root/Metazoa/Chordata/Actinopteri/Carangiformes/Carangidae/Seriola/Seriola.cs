using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Seriola;

/// <summary>
/// Abstract class for Seriola (genus).
/// NCBI TaxId: 8160
/// </summary>
public abstract class Seriola : Carangidae, ISeriola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seriola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8160;

    /// <inheritdoc />
    public virtual string GenusName => "Seriola";

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
