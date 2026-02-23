using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Agamyxis;

/// <summary>
/// Abstract class for Agamyxis (genus).
/// NCBI TaxId: 238585
/// </summary>
public abstract class Agamyxis : Doradidae, IAgamyxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agamyxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238585;

    /// <inheritdoc />
    public virtual string GenusName => "Agamyxis";

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
