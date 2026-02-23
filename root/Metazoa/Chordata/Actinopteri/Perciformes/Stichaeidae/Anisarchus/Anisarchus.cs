using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Anisarchus;

/// <summary>
/// Abstract class for Anisarchus (genus).
/// NCBI TaxId: 980384
/// </summary>
public abstract class Anisarchus : Stichaeidae, IAnisarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anisarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980384;

    /// <inheritdoc />
    public virtual string GenusName => "Anisarchus";

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
