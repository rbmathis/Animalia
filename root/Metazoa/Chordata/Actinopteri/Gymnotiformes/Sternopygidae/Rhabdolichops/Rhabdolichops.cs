using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Rhabdolichops;

/// <summary>
/// Abstract class for Rhabdolichops (genus).
/// NCBI TaxId: 36701
/// </summary>
public abstract class Rhabdolichops : Sternopygidae, IRhabdolichops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdolichops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36701;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdolichops";

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
