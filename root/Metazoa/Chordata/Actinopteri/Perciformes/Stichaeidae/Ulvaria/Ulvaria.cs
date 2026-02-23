using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Ulvaria;

/// <summary>
/// Abstract class for Ulvaria (genus).
/// NCBI TaxId: 262900
/// </summary>
public abstract class Ulvaria : Stichaeidae, IUlvaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ulvaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262900;

    /// <inheritdoc />
    public virtual string GenusName => "Ulvaria";

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
