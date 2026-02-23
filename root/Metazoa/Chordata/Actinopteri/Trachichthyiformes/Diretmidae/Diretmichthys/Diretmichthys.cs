using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmichthys;

/// <summary>
/// Abstract class for Diretmichthys (genus).
/// NCBI TaxId: 1311543
/// </summary>
public abstract class Diretmichthys : Diretmidae, IDiretmichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diretmichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311543;

    /// <inheritdoc />
    public virtual string GenusName => "Diretmichthys";

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
