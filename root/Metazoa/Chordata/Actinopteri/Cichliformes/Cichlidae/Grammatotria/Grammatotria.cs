using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Grammatotria;

/// <summary>
/// Abstract class for Grammatotria (genus).
/// NCBI TaxId: 27744
/// </summary>
public abstract class Grammatotria : Cichlidae, IGrammatotria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammatotria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27744;

    /// <inheritdoc />
    public virtual string GenusName => "Grammatotria";

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
