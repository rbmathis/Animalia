using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Deuterodon;

/// <summary>
/// Abstract class for Deuterodon (genus).
/// NCBI TaxId: 930316
/// </summary>
public abstract class Deuterodon : Acestrorhamphidae, IDeuterodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deuterodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930316;

    /// <inheritdoc />
    public virtual string GenusName => "Deuterodon";

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
