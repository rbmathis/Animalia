using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Peristrominous;

/// <summary>
/// Abstract class for Peristrominous (genus).
/// NCBI TaxId: 2578401
/// </summary>
public abstract class Peristrominous : Aploactinidae, IPeristrominous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peristrominous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578401;

    /// <inheritdoc />
    public virtual string GenusName => "Peristrominous";

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
