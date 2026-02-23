using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Pseudobatos;

/// <summary>
/// Abstract class for Pseudobatos (genus).
/// NCBI TaxId: 2282851
/// </summary>
public abstract class Pseudobatos : Rhinobatidae, IPseudobatos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobatos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2282851;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobatos";

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
