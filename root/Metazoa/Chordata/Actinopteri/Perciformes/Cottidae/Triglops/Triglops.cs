using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Triglops;

/// <summary>
/// Abstract class for Triglops (genus).
/// NCBI TaxId: 274769
/// </summary>
public abstract class Triglops : Cottidae, ITriglops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triglops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274769;

    /// <inheritdoc />
    public virtual string GenusName => "Triglops";

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
