using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Hypseleotris;

/// <summary>
/// Abstract class for Hypseleotris (genus).
/// NCBI TaxId: 86238
/// </summary>
public abstract class Hypseleotris : Eleotridae, IHypseleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypseleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86238;

    /// <inheritdoc />
    public virtual string GenusName => "Hypseleotris";

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
