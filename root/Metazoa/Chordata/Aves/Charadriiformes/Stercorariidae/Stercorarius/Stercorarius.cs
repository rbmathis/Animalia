using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

/// <summary>
/// Abstract class for Stercorarius (genus).
/// NCBI TaxId: 54057
/// </summary>
public abstract class Stercorarius : Stercorariidae, IStercorarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stercorarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54057;

    /// <inheritdoc />
    public virtual string GenusName => "Stercorarius";

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
