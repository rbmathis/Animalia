using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Incaspiza;

/// <summary>
/// Abstract class for Incaspiza (genus).
/// NCBI TaxId: 1226233
/// </summary>
public abstract class Incaspiza : Thraupidae, IIncaspiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Incaspiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226233;

    /// <inheritdoc />
    public virtual string GenusName => "Incaspiza";

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
