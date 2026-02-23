using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Heliobletus;

/// <summary>
/// Abstract class for Heliobletus (genus).
/// NCBI TaxId: 329515
/// </summary>
public abstract class Heliobletus : Furnariidae, IHeliobletus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliobletus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329515;

    /// <inheritdoc />
    public virtual string GenusName => "Heliobletus";

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
