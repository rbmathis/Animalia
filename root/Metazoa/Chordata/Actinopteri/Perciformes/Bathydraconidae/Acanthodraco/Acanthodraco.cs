using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Acanthodraco;

/// <summary>
/// Abstract class for Acanthodraco (genus).
/// NCBI TaxId: 202052
/// </summary>
public abstract class Acanthodraco : Bathydraconidae, IAcanthodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202052;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthodraco";

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
