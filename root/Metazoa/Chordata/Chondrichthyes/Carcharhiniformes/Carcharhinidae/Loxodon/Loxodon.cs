using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Loxodon;

/// <summary>
/// Abstract class for Loxodon (genus).
/// NCBI TaxId: 884672
/// </summary>
public abstract class Loxodon : Carcharhinidae, ILoxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 884672;

    /// <inheritdoc />
    public virtual string GenusName => "Loxodon";

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
