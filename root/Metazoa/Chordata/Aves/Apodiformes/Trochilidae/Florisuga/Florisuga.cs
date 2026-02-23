using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Florisuga;

/// <summary>
/// Abstract class for Florisuga (genus).
/// NCBI TaxId: 304639
/// </summary>
public abstract class Florisuga : Trochilidae, IFlorisuga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Florisuga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304639;

    /// <inheritdoc />
    public virtual string GenusName => "Florisuga";

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
