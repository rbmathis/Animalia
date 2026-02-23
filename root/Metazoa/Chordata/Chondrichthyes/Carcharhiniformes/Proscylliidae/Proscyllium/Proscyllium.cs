using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Proscyllium;

/// <summary>
/// Abstract class for Proscyllium (genus).
/// NCBI TaxId: 263715
/// </summary>
public abstract class Proscyllium : Proscylliidae, IProscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263715;

    /// <inheritdoc />
    public virtual string GenusName => "Proscyllium";

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
