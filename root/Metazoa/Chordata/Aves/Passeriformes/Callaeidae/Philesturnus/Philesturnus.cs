using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Philesturnus;

/// <summary>
/// Abstract class for Philesturnus (genus).
/// NCBI TaxId: 2133942
/// </summary>
public abstract class Philesturnus : Callaeidae, IPhilesturnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philesturnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2133942;

    /// <inheritdoc />
    public virtual string GenusName => "Philesturnus";

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
