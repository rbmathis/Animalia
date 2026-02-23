using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Rhinobatos;

/// <summary>
/// Abstract class for Rhinobatos (genus).
/// NCBI TaxId: 7861
/// </summary>
public abstract class Rhinobatos : Rhinobatidae, IRhinobatos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinobatos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7861;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinobatos";

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
