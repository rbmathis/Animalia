using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Esselenichthys;

/// <summary>
/// Abstract class for Esselenichthys (genus).
/// NCBI TaxId: 320405
/// </summary>
public abstract class Esselenichthys : Stichaeidae, IEsselenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Esselenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320405;

    /// <inheritdoc />
    public virtual string GenusName => "Esselenichthys";

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
