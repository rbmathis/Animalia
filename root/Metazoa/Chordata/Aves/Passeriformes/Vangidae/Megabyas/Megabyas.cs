using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Megabyas;

/// <summary>
/// Abstract class for Megabyas (genus).
/// NCBI TaxId: 2821871
/// </summary>
public abstract class Megabyas : Vangidae, IMegabyas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megabyas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821871;

    /// <inheritdoc />
    public virtual string GenusName => "Megabyas";

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
