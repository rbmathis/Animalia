using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rhinemys;

/// <summary>
/// Abstract class for Rhinemys (genus).
/// NCBI TaxId: 904228
/// </summary>
public abstract class Rhinemys : Chelidae, IRhinemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 904228;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinemys";

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
