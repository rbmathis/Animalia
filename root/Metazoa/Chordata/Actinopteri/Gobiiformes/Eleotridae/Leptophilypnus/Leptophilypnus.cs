using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Leptophilypnus;

/// <summary>
/// Abstract class for Leptophilypnus (genus).
/// NCBI TaxId: 308073
/// </summary>
public abstract class Leptophilypnus : Eleotridae, ILeptophilypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptophilypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308073;

    /// <inheritdoc />
    public virtual string GenusName => "Leptophilypnus";

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
