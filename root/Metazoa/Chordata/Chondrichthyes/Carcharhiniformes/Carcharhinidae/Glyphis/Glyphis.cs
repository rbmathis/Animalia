using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Glyphis;

/// <summary>
/// Abstract class for Glyphis (genus).
/// NCBI TaxId: 496087
/// </summary>
public abstract class Glyphis : Carcharhinidae, IGlyphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496087;

    /// <inheritdoc />
    public virtual string GenusName => "Glyphis";

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
