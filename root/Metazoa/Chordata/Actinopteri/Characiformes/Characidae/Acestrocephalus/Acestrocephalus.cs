using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Acestrocephalus;

/// <summary>
/// Abstract class for Acestrocephalus (genus).
/// NCBI TaxId: 930277
/// </summary>
public abstract class Acestrocephalus : Characidae, IAcestrocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acestrocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930277;

    /// <inheritdoc />
    public virtual string GenusName => "Acestrocephalus";

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
