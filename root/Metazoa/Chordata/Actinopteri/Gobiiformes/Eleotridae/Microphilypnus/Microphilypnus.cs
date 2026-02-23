using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Microphilypnus;

/// <summary>
/// Abstract class for Microphilypnus (genus).
/// NCBI TaxId: 308095
/// </summary>
public abstract class Microphilypnus : Eleotridae, IMicrophilypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microphilypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308095;

    /// <inheritdoc />
    public virtual string GenusName => "Microphilypnus";

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
