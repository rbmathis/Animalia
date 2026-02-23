using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Kasatkia;

/// <summary>
/// Abstract class for Kasatkia (genus).
/// NCBI TaxId: 320407
/// </summary>
public abstract class Kasatkia : Stichaeidae, IKasatkia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kasatkia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320407;

    /// <inheritdoc />
    public virtual string GenusName => "Kasatkia";

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
