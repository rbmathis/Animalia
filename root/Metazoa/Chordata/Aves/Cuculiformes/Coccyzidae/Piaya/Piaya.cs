using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Piaya;

/// <summary>
/// Abstract class for Piaya (genus).
/// NCBI TaxId: 33600
/// </summary>
public abstract class Piaya : Coccyzidae, IPiaya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piaya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33600;

    /// <inheritdoc />
    public virtual string GenusName => "Piaya";

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
