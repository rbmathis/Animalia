using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Megalocottus;

/// <summary>
/// Abstract class for Megalocottus (genus).
/// NCBI TaxId: 476924
/// </summary>
public abstract class Megalocottus : Cottidae, IMegalocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 476924;

    /// <inheritdoc />
    public virtual string GenusName => "Megalocottus";

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
