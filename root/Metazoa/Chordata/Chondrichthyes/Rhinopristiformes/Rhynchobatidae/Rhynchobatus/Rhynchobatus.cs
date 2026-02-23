using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

/// <summary>
/// Abstract class for Rhynchobatus (genus).
/// NCBI TaxId: 117880
/// </summary>
public abstract class Rhynchobatus : Rhynchobatidae, IRhynchobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117880;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchobatus";

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
