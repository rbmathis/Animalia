using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Cygnodraco;

/// <summary>
/// Abstract class for Cygnodraco (genus).
/// NCBI TaxId: 8215
/// </summary>
public abstract class Cygnodraco : Bathydraconidae, ICygnodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cygnodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8215;

    /// <inheritdoc />
    public virtual string GenusName => "Cygnodraco";

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
