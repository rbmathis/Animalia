using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Typhlonus;

/// <summary>
/// Abstract class for Typhlonus (genus).
/// NCBI TaxId: 3362471
/// </summary>
public abstract class Typhlonus : Ophidiidae, ITyphlonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362471;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlonus";

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
