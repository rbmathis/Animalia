using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Gymnodraco;

/// <summary>
/// Abstract class for Gymnodraco (genus).
/// NCBI TaxId: 8217
/// </summary>
public abstract class Gymnodraco : Bathydraconidae, IGymnodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8217;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnodraco";

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
