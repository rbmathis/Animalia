using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Stethaprion;

/// <summary>
/// Abstract class for Stethaprion (genus).
/// NCBI TaxId: 642583
/// </summary>
public abstract class Stethaprion : Acestrorhamphidae, IStethaprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stethaprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642583;

    /// <inheritdoc />
    public virtual string GenusName => "Stethaprion";

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
