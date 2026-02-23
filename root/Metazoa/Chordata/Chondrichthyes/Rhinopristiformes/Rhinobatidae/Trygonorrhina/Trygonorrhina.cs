using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Trygonorrhina;

/// <summary>
/// Abstract class for Trygonorrhina (genus).
/// NCBI TaxId: 117883
/// </summary>
public abstract class Trygonorrhina : Rhinobatidae, ITrygonorrhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trygonorrhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117883;

    /// <inheritdoc />
    public virtual string GenusName => "Trygonorrhina";

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
