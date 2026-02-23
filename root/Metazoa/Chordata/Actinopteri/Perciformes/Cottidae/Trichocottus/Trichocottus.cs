using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Trichocottus;

/// <summary>
/// Abstract class for Trichocottus (genus).
/// NCBI TaxId: 1054475
/// </summary>
public abstract class Trichocottus : Cottidae, ITrichocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1054475;

    /// <inheritdoc />
    public virtual string GenusName => "Trichocottus";

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
