using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Dictyosoma;

/// <summary>
/// Abstract class for Dictyosoma (genus).
/// NCBI TaxId: 57789
/// </summary>
public abstract class Dictyosoma : Stichaeidae, IDictyosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dictyosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57789;

    /// <inheritdoc />
    public virtual string GenusName => "Dictyosoma";

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
