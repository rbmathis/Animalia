using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Ruscarius;

/// <summary>
/// Abstract class for Ruscarius (genus).
/// NCBI TaxId: 320606
/// </summary>
public abstract class Ruscarius : Cottidae, IRuscarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ruscarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320606;

    /// <inheritdoc />
    public virtual string GenusName => "Ruscarius";

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
