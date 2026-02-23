using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Ballerus;

/// <summary>
/// Abstract class for Ballerus (genus).
/// NCBI TaxId: 1112884
/// </summary>
public abstract class Ballerus : Leuciscidae, IBallerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ballerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1112884;

    /// <inheritdoc />
    public virtual string GenusName => "Ballerus";

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
