using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Leiocassis;

/// <summary>
/// Abstract class for Leiocassis (genus).
/// NCBI TaxId: 78869
/// </summary>
public abstract class Leiocassis : Bagridae, ILeiocassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiocassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78869;

    /// <inheritdoc />
    public virtual string GenusName => "Leiocassis";

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
