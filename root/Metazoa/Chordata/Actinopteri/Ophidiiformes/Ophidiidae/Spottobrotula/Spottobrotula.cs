using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Spottobrotula;

/// <summary>
/// Abstract class for Spottobrotula (genus).
/// NCBI TaxId: 3095263
/// </summary>
public abstract class Spottobrotula : Ophidiidae, ISpottobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spottobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095263;

    /// <inheritdoc />
    public virtual string GenusName => "Spottobrotula";

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
