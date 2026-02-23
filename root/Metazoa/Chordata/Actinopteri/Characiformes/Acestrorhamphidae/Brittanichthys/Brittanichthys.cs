using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Brittanichthys;

/// <summary>
/// Abstract class for Brittanichthys (genus).
/// NCBI TaxId: 681902
/// </summary>
public abstract class Brittanichthys : Acestrorhamphidae, IBrittanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brittanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681902;

    /// <inheritdoc />
    public virtual string GenusName => "Brittanichthys";

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
