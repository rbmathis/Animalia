using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Dannevigia;

/// <summary>
/// Abstract class for Dannevigia (genus).
/// NCBI TaxId: 1843788
/// </summary>
public abstract class Dannevigia : Ophidiidae, IDannevigia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dannevigia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843788;

    /// <inheritdoc />
    public virtual string GenusName => "Dannevigia";

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
