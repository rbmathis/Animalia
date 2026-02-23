using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Oligocottus;

/// <summary>
/// Abstract class for Oligocottus (genus).
/// NCBI TaxId: 328409
/// </summary>
public abstract class Oligocottus : Cottidae, IOligocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328409;

    /// <inheritdoc />
    public virtual string GenusName => "Oligocottus";

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
