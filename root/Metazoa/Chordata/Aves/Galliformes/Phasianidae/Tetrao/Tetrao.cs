using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetrao;

/// <summary>
/// Abstract class for Tetrao (genus).
/// NCBI TaxId: 100829
/// </summary>
public abstract class Tetrao : Phasianidae, ITetrao
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrao";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100829;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrao";

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
