using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Benthocometes;

/// <summary>
/// Abstract class for Benthocometes (genus).
/// NCBI TaxId: 2768311
/// </summary>
public abstract class Benthocometes : Ophidiidae, IBenthocometes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthocometes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768311;

    /// <inheritdoc />
    public virtual string GenusName => "Benthocometes";

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
