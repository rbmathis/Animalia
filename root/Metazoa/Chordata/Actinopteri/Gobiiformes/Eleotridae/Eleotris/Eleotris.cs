using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Eleotris;

/// <summary>
/// Abstract class for Eleotris (genus).
/// NCBI TaxId: 86231
/// </summary>
public abstract class Eleotris : Eleotridae, IEleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86231;

    /// <inheritdoc />
    public virtual string GenusName => "Eleotris";

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
