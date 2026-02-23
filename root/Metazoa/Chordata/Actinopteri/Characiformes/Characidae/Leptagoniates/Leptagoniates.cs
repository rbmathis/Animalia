using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Leptagoniates;

/// <summary>
/// Abstract class for Leptagoniates (genus).
/// NCBI TaxId: 930344
/// </summary>
public abstract class Leptagoniates : Characidae, ILeptagoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptagoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930344;

    /// <inheritdoc />
    public virtual string GenusName => "Leptagoniates";

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
