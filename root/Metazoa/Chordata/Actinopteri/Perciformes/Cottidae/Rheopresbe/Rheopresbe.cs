using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Rheopresbe;

/// <summary>
/// Abstract class for Rheopresbe (genus).
/// NCBI TaxId: 3363477
/// </summary>
public abstract class Rheopresbe : Cottidae, IRheopresbe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheopresbe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363477;

    /// <inheritdoc />
    public virtual string GenusName => "Rheopresbe";

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
