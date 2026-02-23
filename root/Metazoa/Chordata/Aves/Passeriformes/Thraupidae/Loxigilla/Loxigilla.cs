using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Loxigilla;

/// <summary>
/// Abstract class for Loxigilla (genus).
/// NCBI TaxId: 111864
/// </summary>
public abstract class Loxigilla : Thraupidae, ILoxigilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxigilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111864;

    /// <inheritdoc />
    public virtual string GenusName => "Loxigilla";

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
