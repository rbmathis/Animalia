using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Genypterus;

/// <summary>
/// Abstract class for Genypterus (genus).
/// NCBI TaxId: 154953
/// </summary>
public abstract class Genypterus : Ophidiidae, IGenypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154953;

    /// <inheritdoc />
    public virtual string GenusName => "Genypterus";

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
