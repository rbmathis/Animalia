using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Beringraja;

/// <summary>
/// Abstract class for Beringraja (genus).
/// NCBI TaxId: 1885021
/// </summary>
public abstract class Beringraja : Rajidae, IBeringraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beringraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1885021;

    /// <inheritdoc />
    public virtual string GenusName => "Beringraja";

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
