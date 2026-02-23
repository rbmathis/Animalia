using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Brochiraja;

/// <summary>
/// Abstract class for Brochiraja (genus).
/// NCBI TaxId: 1213614
/// </summary>
public abstract class Brochiraja : Rajidae, IBrochiraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brochiraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1213614;

    /// <inheritdoc />
    public virtual string GenusName => "Brochiraja";

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
