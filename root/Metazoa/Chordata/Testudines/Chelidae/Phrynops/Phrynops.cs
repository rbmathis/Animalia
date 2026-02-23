using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Abstract class for Phrynops (genus).
/// NCBI TaxId: 8462
/// </summary>
public abstract class Phrynops : Chelidae, IPhrynops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8462;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynops";

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
