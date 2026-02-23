using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Prionace;

/// <summary>
/// Abstract class for Prionace (genus).
/// NCBI TaxId: 7814
/// </summary>
public abstract class Prionace : Carcharhinidae, IPrionace
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionace";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7814;

    /// <inheritdoc />
    public virtual string GenusName => "Prionace";

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
