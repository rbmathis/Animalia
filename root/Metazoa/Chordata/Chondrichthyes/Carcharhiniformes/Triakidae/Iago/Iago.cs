using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Iago;

/// <summary>
/// Abstract class for Iago (genus).
/// NCBI TaxId: 376631
/// </summary>
public abstract class Iago : Triakidae, IIago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376631;

    /// <inheritdoc />
    public virtual string GenusName => "Iago";

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
