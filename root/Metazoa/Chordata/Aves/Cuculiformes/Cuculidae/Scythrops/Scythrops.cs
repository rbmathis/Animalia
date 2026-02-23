using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Scythrops;

/// <summary>
/// Abstract class for Scythrops (genus).
/// NCBI TaxId: 30393
/// </summary>
public abstract class Scythrops : Cuculidae, IScythrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scythrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30393;

    /// <inheritdoc />
    public virtual string GenusName => "Scythrops";

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
