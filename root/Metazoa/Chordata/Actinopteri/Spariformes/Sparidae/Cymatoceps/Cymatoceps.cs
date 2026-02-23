using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Cymatoceps;

/// <summary>
/// Abstract class for Cymatoceps (genus).
/// NCBI TaxId: 119709
/// </summary>
public abstract class Cymatoceps : Sparidae, ICymatoceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymatoceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119709;

    /// <inheritdoc />
    public virtual string GenusName => "Cymatoceps";

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
