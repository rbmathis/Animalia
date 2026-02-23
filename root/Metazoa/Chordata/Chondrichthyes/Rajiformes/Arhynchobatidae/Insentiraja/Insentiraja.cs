using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Insentiraja;

/// <summary>
/// Abstract class for Insentiraja (genus).
/// NCBI TaxId: 1072465
/// </summary>
public abstract class Insentiraja : Arhynchobatidae, IInsentiraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Insentiraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1072465;

    /// <inheritdoc />
    public virtual string GenusName => "Insentiraja";

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
