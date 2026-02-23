using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Hemieleotris;

/// <summary>
/// Abstract class for Hemieleotris (genus).
/// NCBI TaxId: 308093
/// </summary>
public abstract class Hemieleotris : Eleotridae, IHemieleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemieleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308093;

    /// <inheritdoc />
    public virtual string GenusName => "Hemieleotris";

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
