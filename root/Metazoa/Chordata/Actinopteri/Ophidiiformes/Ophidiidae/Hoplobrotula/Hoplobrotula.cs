using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Hoplobrotula;

/// <summary>
/// Abstract class for Hoplobrotula (genus).
/// NCBI TaxId: 990983
/// </summary>
public abstract class Hoplobrotula : Ophidiidae, IHoplobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990983;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplobrotula";

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
