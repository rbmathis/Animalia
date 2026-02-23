using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Giuris;

/// <summary>
/// Abstract class for Giuris (genus).
/// NCBI TaxId: 1095381
/// </summary>
public abstract class Giuris : Eleotridae, IGiuris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Giuris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1095381;

    /// <inheritdoc />
    public virtual string GenusName => "Giuris";

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
