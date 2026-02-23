using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Robsonius;

/// <summary>
/// Abstract class for Robsonius (genus).
/// NCBI TaxId: 2162876
/// </summary>
public abstract class Robsonius : Locustellidae, IRobsonius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Robsonius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2162876;

    /// <inheritdoc />
    public virtual string GenusName => "Robsonius";

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
