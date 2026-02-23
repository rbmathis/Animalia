using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Daptrius;

/// <summary>
/// Abstract class for Daptrius (genus).
/// NCBI TaxId: 56346
/// </summary>
public abstract class Daptrius : Falconidae, IDaptrius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daptrius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56346;

    /// <inheritdoc />
    public virtual string GenusName => "Daptrius";

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
