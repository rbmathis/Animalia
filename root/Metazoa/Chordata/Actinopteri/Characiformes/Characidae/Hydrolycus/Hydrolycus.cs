using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Hydrolycus;

/// <summary>
/// Abstract class for Hydrolycus (genus).
/// NCBI TaxId: 272074
/// </summary>
public abstract class Hydrolycus : Characidae, IHydrolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272074;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrolycus";

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
