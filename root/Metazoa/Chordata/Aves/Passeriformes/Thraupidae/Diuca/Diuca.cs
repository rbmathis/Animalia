using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Diuca;

/// <summary>
/// Abstract class for Diuca (genus).
/// NCBI TaxId: 460192
/// </summary>
public abstract class Diuca : Thraupidae, IDiuca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diuca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460192;

    /// <inheritdoc />
    public virtual string GenusName => "Diuca";

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
