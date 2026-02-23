using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Eumesogrammus;

/// <summary>
/// Abstract class for Eumesogrammus (genus).
/// NCBI TaxId: 980386
/// </summary>
public abstract class Eumesogrammus : Stichaeidae, IEumesogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumesogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980386;

    /// <inheritdoc />
    public virtual string GenusName => "Eumesogrammus";

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
