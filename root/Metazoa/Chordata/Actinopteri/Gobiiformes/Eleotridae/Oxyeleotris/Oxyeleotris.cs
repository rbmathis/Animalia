using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Oxyeleotris;

/// <summary>
/// Abstract class for Oxyeleotris (genus).
/// NCBI TaxId: 86249
/// </summary>
public abstract class Oxyeleotris : Eleotridae, IOxyeleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyeleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86249;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyeleotris";

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
