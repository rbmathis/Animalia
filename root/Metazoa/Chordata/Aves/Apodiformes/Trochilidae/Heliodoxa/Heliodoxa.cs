using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliodoxa;

/// <summary>
/// Abstract class for Heliodoxa (genus).
/// NCBI TaxId: 304646
/// </summary>
public abstract class Heliodoxa : Trochilidae, IHeliodoxa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliodoxa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304646;

    /// <inheritdoc />
    public virtual string GenusName => "Heliodoxa";

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
