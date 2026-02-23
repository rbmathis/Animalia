using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Bathydraco;

/// <summary>
/// Abstract class for Bathydraco (genus).
/// NCBI TaxId: 12963
/// </summary>
public abstract class Bathydraco : Bathydraconidae, IBathydraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathydraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 12963;

    /// <inheritdoc />
    public virtual string GenusName => "Bathydraco";

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
