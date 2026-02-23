using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Pareiodon;

/// <summary>
/// Abstract class for Pareiodon (genus).
/// NCBI TaxId: 648140
/// </summary>
public abstract class Pareiodon : Trichomycteridae, IPareiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648140;

    /// <inheritdoc />
    public virtual string GenusName => "Pareiodon";

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
