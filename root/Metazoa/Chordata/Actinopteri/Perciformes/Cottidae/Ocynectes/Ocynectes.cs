using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Ocynectes;

/// <summary>
/// Abstract class for Ocynectes (genus).
/// NCBI TaxId: 1802976
/// </summary>
public abstract class Ocynectes : Cottidae, IOcynectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocynectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1802976;

    /// <inheritdoc />
    public virtual string GenusName => "Ocynectes";

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
