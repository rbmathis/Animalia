using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Gerlachea;

/// <summary>
/// Abstract class for Gerlachea (genus).
/// NCBI TaxId: 202059
/// </summary>
public abstract class Gerlachea : Bathydraconidae, IGerlachea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerlachea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202059;

    /// <inheritdoc />
    public virtual string GenusName => "Gerlachea";

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
