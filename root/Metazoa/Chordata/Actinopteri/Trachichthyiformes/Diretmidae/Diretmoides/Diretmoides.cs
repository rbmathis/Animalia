using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmoides;

/// <summary>
/// Abstract class for Diretmoides (genus).
/// NCBI TaxId: 181430
/// </summary>
public abstract class Diretmoides : Diretmidae, IDiretmoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diretmoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181430;

    /// <inheritdoc />
    public virtual string GenusName => "Diretmoides";

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
