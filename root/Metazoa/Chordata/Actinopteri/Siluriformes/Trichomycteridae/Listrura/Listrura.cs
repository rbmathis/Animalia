using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Listrura;

/// <summary>
/// Abstract class for Listrura (genus).
/// NCBI TaxId: 871687
/// </summary>
public abstract class Listrura : Trichomycteridae, IListrura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Listrura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 871687;

    /// <inheritdoc />
    public virtual string GenusName => "Listrura";

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
