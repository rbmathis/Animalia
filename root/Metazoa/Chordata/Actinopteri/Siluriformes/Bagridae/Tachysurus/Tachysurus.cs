using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Tachysurus;

/// <summary>
/// Abstract class for Tachysurus (genus).
/// NCBI TaxId: 641818
/// </summary>
public abstract class Tachysurus : Bagridae, ITachysurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachysurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641818;

    /// <inheritdoc />
    public virtual string GenusName => "Tachysurus";

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
