using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Selachophidium;

/// <summary>
/// Abstract class for Selachophidium (genus).
/// NCBI TaxId: 991005
/// </summary>
public abstract class Selachophidium : Ophidiidae, ISelachophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selachophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 991005;

    /// <inheritdoc />
    public virtual string GenusName => "Selachophidium";

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
