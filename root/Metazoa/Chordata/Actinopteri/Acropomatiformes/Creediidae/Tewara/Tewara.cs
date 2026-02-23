using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Tewara;

/// <summary>
/// Abstract class for Tewara (genus).
/// NCBI TaxId: 1703797
/// </summary>
public abstract class Tewara : Creediidae, ITewara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tewara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1703797;

    /// <inheritdoc />
    public virtual string GenusName => "Tewara";

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
