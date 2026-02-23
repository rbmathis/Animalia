using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetrastes;

/// <summary>
/// Abstract class for Tetrastes (genus).
/// NCBI TaxId: 1155786
/// </summary>
public abstract class Tetrastes : Phasianidae, ITetrastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1155786;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrastes";

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
