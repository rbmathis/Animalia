using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Eridacnis;

/// <summary>
/// Abstract class for Eridacnis (genus).
/// NCBI TaxId: 1214762
/// </summary>
public abstract class Eridacnis : Proscylliidae, IEridacnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eridacnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1214762;

    /// <inheritdoc />
    public virtual string GenusName => "Eridacnis";

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
