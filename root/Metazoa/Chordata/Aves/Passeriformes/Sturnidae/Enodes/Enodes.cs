using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Enodes;

/// <summary>
/// Abstract class for Enodes (genus).
/// NCBI TaxId: 451432
/// </summary>
public abstract class Enodes : Sturnidae, IEnodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451432;

    /// <inheritdoc />
    public virtual string GenusName => "Enodes";

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
