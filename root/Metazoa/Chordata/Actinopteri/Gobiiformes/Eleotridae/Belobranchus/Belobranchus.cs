using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Belobranchus;

/// <summary>
/// Abstract class for Belobranchus (genus).
/// NCBI TaxId: 641933
/// </summary>
public abstract class Belobranchus : Eleotridae, IBelobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641933;

    /// <inheritdoc />
    public virtual string GenusName => "Belobranchus";

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
