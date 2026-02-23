using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Psilodraco;

/// <summary>
/// Abstract class for Psilodraco (genus).
/// NCBI TaxId: 202070
/// </summary>
public abstract class Psilodraco : Bathydraconidae, IPsilodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202070;

    /// <inheritdoc />
    public virtual string GenusName => "Psilodraco";

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
