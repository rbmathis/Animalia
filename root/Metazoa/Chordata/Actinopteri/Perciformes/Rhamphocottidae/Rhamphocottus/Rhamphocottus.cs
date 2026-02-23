using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Rhamphocottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Rhamphocottidae.Rhamphocottus;

/// <summary>
/// Abstract class for Rhamphocottus (genus).
/// NCBI TaxId: 274755
/// </summary>
public abstract class Rhamphocottus : Rhamphocottidae, IRhamphocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274755;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphocottus";

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
