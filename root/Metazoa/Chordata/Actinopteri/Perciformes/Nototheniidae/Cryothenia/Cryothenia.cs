using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Cryothenia;

/// <summary>
/// Abstract class for Cryothenia (genus).
/// NCBI TaxId: 369903
/// </summary>
public abstract class Cryothenia : Nototheniidae, ICryothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369903;

    /// <inheritdoc />
    public virtual string GenusName => "Cryothenia";

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
