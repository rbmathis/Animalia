using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmus;

/// <summary>
/// Abstract class for Diretmus (genus).
/// NCBI TaxId: 88681
/// </summary>
public abstract class Diretmus : Diretmidae, IDiretmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diretmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88681;

    /// <inheritdoc />
    public virtual string GenusName => "Diretmus";

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
