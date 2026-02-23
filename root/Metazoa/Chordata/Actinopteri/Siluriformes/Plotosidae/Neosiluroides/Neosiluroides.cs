using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Neosiluroides;

/// <summary>
/// Abstract class for Neosiluroides (genus).
/// NCBI TaxId: 882207
/// </summary>
public abstract class Neosiluroides : Plotosidae, INeosiluroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosiluroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882207;

    /// <inheritdoc />
    public virtual string GenusName => "Neosiluroides";

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
