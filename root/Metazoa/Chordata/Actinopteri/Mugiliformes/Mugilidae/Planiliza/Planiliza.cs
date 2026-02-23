using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Planiliza;

/// <summary>
/// Abstract class for Planiliza (genus).
/// NCBI TaxId: 1935872
/// </summary>
public abstract class Planiliza : Mugilidae, IPlaniliza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Planiliza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935872;

    /// <inheritdoc />
    public virtual string GenusName => "Planiliza";

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
