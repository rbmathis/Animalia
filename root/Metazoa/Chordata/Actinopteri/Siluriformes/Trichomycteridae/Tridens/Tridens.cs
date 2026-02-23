using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Tridens;

/// <summary>
/// Abstract class for Tridens (genus).
/// NCBI TaxId: 210604
/// </summary>
public abstract class Tridens : Trichomycteridae, ITridens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tridens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210604;

    /// <inheritdoc />
    public virtual string GenusName => "Tridens";

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
